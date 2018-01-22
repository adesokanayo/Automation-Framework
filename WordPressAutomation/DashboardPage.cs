
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WordPressAutomation
{
   public  class DashboardPage
    {

        public static bool IsAt
        {
            get{

                var WelcomeTitle = Driver.Instance.FindElements(By.ClassName("profile-name"));

                if (WelcomeTitle.Count > 0)
                    return WelcomeTitle[0].Text == "Good";
                return false;
            }
        }
    }
}
