using System;
using System.Net;
using System.Net.Sockets;


namespace ntp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            using (UdpClient client = new UdpClient())
            {
                string ntpServer = "0.ch.pool.ntp.org";
                Console.WriteLine(ntpServer);

                byte[] timeMessage = new byte[48];
                timeMessage[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                Console.WriteLine(timeMessage[0]);

                IPEndPoint ntpReference = new IPEndPoint(Dns.GetHostAddresses(ntpServer)[0], 123);

                client.Connect(ntpReference);

                client.Send(timeMessage, timeMessage.Length);

                timeMessage = client.Receive(ref ntpReference);

                Console.WriteLine(timeMessage); //doesnt work

                DateTime ntpTime = NtpPacket.ToDateTime(timeMessage);

                Console.WriteLine($"Heure actuelle (format 1) : {ntpTime}");
                Console.WriteLine($"Heure actuelle (format 2) : {ntpTime.ToString("dddd, d MMMM yyyy")}");
                Console.WriteLine($"Heure actuelle (format 3) : {ntpTime.ToString("d")}");

                Console.WriteLine($"Heure actuelle (format ISO 8601) : {ntpTime.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'")}");

                DateTime dateTimeLocal = DateTime.UtcNow;

                TimeSpan timeDifference = dateTimeLocal - ntpTime;

                Console.WriteLine($"Différence de temps : {timeDifference.TotalSeconds:F10} secondes");

                dateTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(ntpTime, TimeZoneInfo.Local);

                Console.WriteLine(dateTimeLocal);

                //ex 3
                TimeZoneInfo swissTimeZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");

                DateTime swissTime = TimeZoneInfo.ConvertTimeFromUtc(ntpTime, swissTimeZone);

                Console.WriteLine("Heure Suisse : " + swissTime);

                //ex 4

                ntpTime = TimeZoneInfo.ConvertTimeFromUtc(ntpTime, TimeZoneInfo.FindSystemTimeZoneById("UTC"));

                Console.WriteLine("Heure UTC : " + ntpTime);


                client.Close();

            }

        }
    }

    public class NtpPacket()
    {
        public static DateTime ToDateTime(byte[] ntpData)
        {
            ulong intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | (ulong)ntpData[43];
            ulong fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | (ulong)ntpData[47];

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);

            return Convert.ToDateTime(networkDateTime);
        }

    }

}
