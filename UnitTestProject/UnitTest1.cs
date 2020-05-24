using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetConnStringFromAppConfig()
        {
            DataBase da = new DataBase();
            string actualString = da.connection_String;
            string expectedString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn_String"].ConnectionString;
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
