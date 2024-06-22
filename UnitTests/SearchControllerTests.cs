using Controllers;
using Controllers.Models;
using Moq;
using SerpAPI.Models;
using SerpAPILibrary;
namespace UnitTests
{
    public class Controllers
    {
        private SearchController _controller;
        private readonly Mock<ISerpAPI> _serp = new Mock<ISerpAPI>();
        [SetUp]
        public void Setup()
        {
            _controller = new SearchController(_serp.Object);
        }

        [Test]
        public void CanGetSeoPostition()
        {
            //Arrange
            var searchForm = new SearchForm(keyWord: "conveyancing software", url: "www.smokeball.com.au");
            var mockOrganicResults = new List<OrganicResult>()
            {
                new OrganicResult()
                {
                    Position=2,
                    Link="www.smokeball.com.au"
                },
                 new OrganicResult()
                {
                    Position=7,
                    Link="www.google.com.au"
                },
                  new OrganicResult()
                {
                    Position=9,
                    Link="www.smokeballfake.com.au"
                },
                   new OrganicResult()
                {
                    Position=10,
                    Link="www.smokeball.com.au/software"
                }

            };
            _serp.Setup(x => x.GetOrganicResults(searchForm)).Returns(mockOrganicResults);


            //Act
            var res = _controller.GetSeoPostition(searchForm);

            //Assert

            Assert.IsNotNull(res);
            Assert.IsFalse(String.IsNullOrEmpty(res.Result));
            Assert.IsTrue(String.Equals(res.Result,"2, 10"));
        }


        [Test]
        public void CanHandleNoRecordsFound()
        {
            //Arrange
            var searchForm = new SearchForm(keyWord: "conveyancing software", url: "www.smokeball.com.au");
            var mockOrganicResults = new List<OrganicResult>()
            {
                 new OrganicResult()
                {
                    Position=7,
                    Link="www.google.com.au"
                },
                  new OrganicResult()
                {
                    Position=9,
                    Link="www.smokeballfake.com.au"
                }

            };
            _serp.Setup(x => x.GetOrganicResults(searchForm)).Returns(mockOrganicResults);


            //Act
            var res = _controller.GetSeoPostition(searchForm);

            //Assert

            Assert.IsNotNull(res);
            Assert.IsFalse(String.IsNullOrEmpty(res.Result));
            Assert.IsTrue(String.Equals(res.Result, "0"));
        }
    }
}