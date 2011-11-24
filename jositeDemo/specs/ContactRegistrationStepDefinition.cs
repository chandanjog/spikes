using TechTalk.SpecFlow;
using specs.StepHelpers;

namespace specs
{
    [Binding]
    public class ContactRegistrationStepDefinition
    {
        [Given(@"I am on the Home page")]
        public void GivenIAmOnTheHomePage()
        {
//            WebBrowser.Current.GoTo("http://localhost/jobsiteDemo");
            WebBrowser.Driver.Navigate().GoToUrl("http://localhost/jobsiteDemo");
        }

        [When(@"I click the about tab")]
        public void WhenIClickTheAboutTab()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see some text")]
        public void ThenIShouldSeeSomeText()
        {
            ScenarioContext.Current.Pending();
        }
 
    }
}
