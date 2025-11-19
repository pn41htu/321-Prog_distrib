namespace Transat;

public class ResilientPublisher(FaillibleQos0Storage storage1, FaillibleQos0Storage storage2)
{
    private readonly string _id = Guid.NewGuid().ToString("n");

    public void Send(int message)
    {
        string _id2 = Guid.NewGuid().ToString("n");


        while (!storage1.Data.Keys.Any(key => key.StartsWith(_id2)))
        {
            storage1.Store(_id2, message);

        }
        while (!storage2.Data.Keys.Any(key => key.StartsWith(_id2)))
        {
            storage2.Store(_id2, message);

        }


    }
}