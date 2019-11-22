using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework;
using SeleniumExtras;

namespace UnitTestProject1
{
    [TestClass]
    public class TesteFunctional : SeleniumTest
    {
        [TestMethod]
        [TestCategory("Homolog")]
        public void TestMethod1()
        {
            DriverContext.Current.Headless = false;

            Login.Login();

            Navigate(BaseUrl.ToString());
            Click(Map.Map.DevLink, "Dev link");
        }
    }
}
