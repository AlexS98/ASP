using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MySiteMVC4.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {        
        [TestMethod()]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void KarpTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Karp() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void UkrTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Ukr() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void AboutTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void VidgukTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Vidguk() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}