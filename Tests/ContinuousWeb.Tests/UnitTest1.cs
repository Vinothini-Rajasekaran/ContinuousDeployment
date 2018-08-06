using System;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTests()
        {
            var homeController = new ContinuousDeployment.Controllers.HomeController();
            var result = homeController.About();
        }
    }

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}
