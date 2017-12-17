using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MySiteMVC4.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        HomeController controller = new HomeController();
        [TestMethod()]
        public void IndexTest()
        {
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void KarpTest()
        {
            ViewResult result = controller.Karp() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void UkrTest()
        {
            ViewResult result = controller.Ukr() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void AboutTest()
        {
            ViewResult result = controller.About() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void VidgukTest()
        {
            ViewResult result = controller.Vidguk() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}