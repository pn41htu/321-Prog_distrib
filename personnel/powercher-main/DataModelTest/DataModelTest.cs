using DataModel;
using System.Text.Json;

namespace DataModelTest
{
    [TestClass]
    public class DataModelTest
    {
        [TestMethod]
        public void Test_marshalling_TownEnvironment()
        {
            TownEnvironment te = new TownEnvironment(DateTime.Now, 2, 60, 4, WindDirections.NE);

            string json = JsonSerializer.Serialize(te);

            TownEnvironment res = JsonSerializer.Deserialize<TownEnvironment>(json);

            Assert.IsNotNull(res);
            Assert.AreEqual(te.DateTime, res.DateTime);
            Assert.AreEqual(te.SolarEnergy, res.SolarEnergy);
            Assert.AreEqual(te.Clouds, res.Clouds);
            Assert.AreEqual(te.WindSpeed, res.WindSpeed);
            Assert.AreEqual(te.WindDirection, res.WindDirection);
        }

        [TestMethod]
        public void Test_working_schedule()
        {
            // Arrange
            ConsumingAppliance fridge = new ConsumingAppliance(Catalog.ConsumingAppliances[0],"1232");

            // Assert its not working
            Assert.AreEqual(0, fridge.ConsumingAt(new DateTime(2020, 10, 10, 5, 0, 0)));

            // Arrange a working schedule
            fridge.Schedule = new WorkingSchedule(new WorkingTime(new TimeOnly(3, 0), new TimeOnly(20, 0),0.9));

            // Assert it working during the hours
            Assert.AreEqual(0, fridge.ConsumingAt(new DateTime(2020, 10, 10, 2, 0, 0)));
            Assert.AreEqual(0.9*fridge.Description.Power, fridge.ConsumingAt(new DateTime(2020, 10, 10, 5, 0, 0)));

            try
            {
                // Assert
                // Add conficting schedules must fail
                fridge.Schedule.AddWorkingTime(new WorkingTime(new TimeOnly(5, 0), new TimeOnly(23, 0), 1));
                fridge.Schedule.AddWorkingTime(new WorkingTime(new TimeOnly(1, 0), new TimeOnly(19, 55), 1));
                Assert.Fail(); // we must not get to this point
            }
            catch (Exception ex)
            {
                // Assert correct exception
                if (!ex.Message.StartsWith("Conflict")) Assert.Fail("Unexpected exception type");
            }

            // Arrange a schedule over midnight
            fridge.Schedule.AddWorkingTime(new WorkingTime(new TimeOnly(23, 0), new TimeOnly(1, 0), 0.5));

            // Assert it's working at midnight
            Assert.AreEqual(0.5 * fridge.Description.Power, fridge.ConsumingAt(new DateTime(2020, 10, 10, 0, 0, 0)));
        }

    }
}