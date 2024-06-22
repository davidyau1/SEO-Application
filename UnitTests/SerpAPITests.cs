using Controllers.Models;
using Moq;
using Newtonsoft.Json.Linq;
using SerpAPILibrary;
using SerpAPILibrary.Models;
using SerpAPILibrary;
namespace UnitTests
{
    public class SerpAPIs
    {
        private SerpAPI _serpAPI;
        private string _mockDataPath = "..\\..\\..\\MockData\\SerpAPITestData.json";

        [SetUp]
        public void Setup()
        {
            _serpAPI = new SerpAPI();
        }

        [Test]
        public void CanGetOrganicResults()
        {
            //Arrange
            var mockData = JObject.Parse(File.ReadAllText(_mockDataPath));
            //Act
            var res = _serpAPI.SerpAPIToOrganicResults(mockData);

            //Assert
            Assert.IsTrue(res.Count > 0);
            Assert.IsTrue(res[0].Position ==1);
            Assert.IsFalse(String.IsNullOrEmpty(res[0].Link));
            
        }
    }
}