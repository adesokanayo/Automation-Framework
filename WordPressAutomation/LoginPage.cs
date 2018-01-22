using OpenQA.Selenium;
using System;

namespace WordPressAutomation
{
    public class LoginPage
    {
        public static void GoTo()

        {
            Driver.Instance.Navigate().GoToUrl("https://ibank.accessbankplc.com/RetailBank/#/");
        }
        

        public static LoginCommand LoginAs(string userName)
        {

            return new LoginCommand(userName);
        }

        public static void Logout()
        {

            var logoutbutton = Driver.Instance.FindElement(By.PartialLinkText("Logout"));

            logoutbutton.Click();
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)

        {
            this.password = password;
            return this;
        }

        public void Login()
        {

            var userlogin = Driver.Instance.FindElement(By.Id("username"));
            userlogin.SendKeys(userName);

            System.Threading.Thread.Sleep(3000);

            var passwordinput = Driver.Instance.FindElement(By.Id("password"));
            passwordinput.SendKeys(password);

            var loginbutton = Driver.Instance.FindElement(By.Id("BW_button_802163"));

            loginbutton.Click();

            System.Threading.Thread.Sleep(8000);

            var spread = Driver.Instance.FindElement(By.Id("bank-info-msgs"));

            if (spread != null)
            {

                Console.WriteLine("spread found!");
            }
            else { Console.WriteLine("spread is absent"); }


            System.Threading.Thread.Sleep(3000);

            var proceedbutton = Driver.Instance.FindElement(By.Id("BW_button_022485"));

            if (proceedbutton !=null)
                {

                Console.WriteLine("I found the button to click"); }
                 
                else {

                Console.WriteLine("Unable to locate proceedbutton");
            }


            System.Threading.Thread.Sleep(3000);
            proceedbutton.Click();


            System.Threading.Thread.Sleep(3000);

        }


    }


        //IAlert alert = Driver.Instance.SwitchTo().Alert();

        //    string alertmessage = Driver.Instance.SwitchTo().Alert().Text;

        //    Console.WriteLine(alertmessage);

        //    // Driver.AlertPicker();

        //    Console.WriteLine("Alert Clicking");

    
}
