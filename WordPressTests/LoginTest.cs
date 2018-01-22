
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;
using System.Configuration;

namespace WordPressTests
{
    [TestClass]
    public class LoginTest

    {

        [TestInitialize]

        public void Init()
        {

            Driver.Initialize();
            
        }



        [TestMethod]
        public void User_Login()
        {

            LoginPage.GoTo();
            LoginPage.LoginAs(ConfigurationManager.AppSettings["username"]).WithPassword(ConfigurationManager.AppSettings["password"]).Login();

            //Assert.IsTrue(DashboardPage.IsAt, "failed to login");

           
        }



    

       // [TestCleanup]

        public  void Cleanup()
       {


          // Driver.Close();
       }

    }
}
