using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using WatiN.Core;
using OpenQA.Selenium;

namespace specs.StepHelpers
{
    public class WebBrowser
    {
        public static IWebDriver Driver = new FirefoxDriver();

//        public static Browser Current
//        {
//            get
//            {
//                if (!ScenarioContext.Current.ContainsKey("browser"))
//                    ScenarioContext.Current["browser"] = new FireFox();
//                return ScenarioContext.Current["browser"] as FireFox;
//            }      
//        }

    }
}
