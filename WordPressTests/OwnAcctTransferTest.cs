
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;
using System.Configuration;





namespace WordPressTests
{
    [TestClass]

    
    public class OwnAcctTransferTest

    {
        [TestInitialize]
        public void Init()
        {

            Driver.Initialize();
        }

      [TestMethod]
        public void Can_transfer_to_own_account()
        {

            LoginPage.GoTo();
           

            LoginPage.LoginAs(ConfigurationManager.AppSettings["username"]).WithPassword(ConfigurationManager.AppSettings["password"]).Login();

            OwnAcctTransferPage.GoTo();

            OwnAcctTransferPage.Transfer();


        }


        [TestCleanup]

        public void Cleanup()
        {


            Driver.Close();
        }

    }
}
