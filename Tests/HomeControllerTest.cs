using MySiteMVC4.Controllers;
using System.Web.Mvc;
using Xunit;

namespace MySiteMVC4.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void KarpTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Karp() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void UkrTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Ukr() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void AboutTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void VidgukTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Vidguk() as ViewResult;
            Assert.NotNull(result);
        }
    }
}