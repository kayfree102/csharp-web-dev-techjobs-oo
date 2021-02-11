using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job testJob;
        [TestInitialize]
        public void InitializationTest()
        {
            testJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobID()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.AreEqual(1, testJob2.Id - testJob1.Id, 0.001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product Tester", testJob.Name);
            Assert.AreEqual("ACME", testJob.EmployerName.Value);
            Assert.AreEqual("Desert", testJob.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", testJob.JobType.Value);
            Assert.AreEqual("Persistence", testJob.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(Equals(testJob1, testJob2));
        }
        [TestMethod]
         public void TestJobsToString()
        {
             Job testJob4 = new Job("Product Tester", new Employer(""), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
             Job testJob5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
             string results = testJob.ToString();
             string[] resultsArr = results.Split("\n");
             Assert.AreEqual(resultsArr[0], "");
             Assert.AreEqual(resultsArr[resultsArr.Length - 1], "");

             results = testJob4.ToString();
             resultsArr = results.Split("\n");
             Assert.AreEqual(resultsArr[2], "Name: Product Tester");
             Assert.AreEqual(resultsArr[3], "Employer: Data not available");

             results = testJob5.ToString();
             resultsArr = results.Split("\n");
             Assert.AreEqual(resultsArr[1], "OOPS! This job does not seem to exist.");

            }
        }
}
