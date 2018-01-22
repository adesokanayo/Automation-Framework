using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;



namespace WordPressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance {get;set;}
   

         public  static void Initialize()
    {

            // Instance = new FirefoxDriver(@"c:\dev\tools");
            Instance = new ChromeDriver(@"c:\dev\tools");
  
           Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(5));
            //wait.Until(d=> d.FindElement(By.Id("username") = string.Empty));
           wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("imgpmalogo")));
        }


        public static IAlert AlertPicker() {
            IAlert alert = Instance.SwitchTo().Alert();
            return alert;
        }
        
      


        public static void Close ()    {
          
            Instance.Close();

           
        }
    }

    
}