using OpenQA.Selenium;

namespace PageObjects
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected Waiters wait;
        protected Action action;
        protected Assertions assertions;
        protected Elements elements;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new Waiters(driver);
            this.action = new Action(driver);
            this.assertions = new Assertions(driver);
            this.elements = new Elements(driver);
        }
    }
}
