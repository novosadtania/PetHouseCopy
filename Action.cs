using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace PageObjects
{
    public class Action
    {
        private IWebDriver driver;
        private Elements elements;
        private Actions actions;

        public Action(IWebDriver driver)
        {
            this.driver = driver;
            elements = new Elements(driver);
            actions = new Actions(driver);
        }

        public void MoveTo(By by)
        {
            actions.MoveToElement(elements.FindElement(by)).Perform();
        }
    }
}
