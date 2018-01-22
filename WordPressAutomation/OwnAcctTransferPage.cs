using OpenQA.Selenium;
using WordPressAutomation;
using OpenQA.Selenium.Support.UI;



namespace WordPressTests
{
    public class OwnAcctTransferPage
    {
        public static void GoTo()
        {

            var transferbutton =   Driver.Instance.FindElement(By.Id("BW_href_195824"));
            transferbutton.Click();

           var  ownacctbtn = Driver.Instance.FindElement(By.Id("BW_click_059779"));

            ownacctbtn.Click();

            System.Threading.Thread.Sleep(3000);

        }

        public static void Transfer()
        {
            //find element by id(source_account")

            SelectElement sourceacct = new SelectElement(Driver.Instance.FindElement(By.Id("source_account")));

            //pick the first account

            sourceacct.SelectByIndex(1);

            //select destination_account")

            SelectElement destacct = new SelectElement(Driver.Instance.FindElement(By.Id("destination_account")));

            //pick the second account

            destacct.SelectByIndex(2);


            var transferamount = Driver.Instance.FindElement(By.Id("fundstransfer_amountsrc"));

            //send amount
            transferamount.SendKeys("1");

            //send a
            var narration = Driver.Instance.FindElement(By.Id("fundstransfer_srcnarrative"));

            narration.SendKeys("selenium");


            var sendbutton = Driver.Instance.FindElement(By.Id("fundstransfer_next"));

            sendbutton.Click();

            System.Threading.Thread.Sleep(3000);

            var nxtsendbutton = Driver.Instance.FindElement(By.Id("showamountselector_next"));

            nxtsendbutton.Click();

            System.Threading.Thread.Sleep(3000);

        }
    }
}