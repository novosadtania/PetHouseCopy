using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class Waiters
    {
        private static TimeSpan timeOut = TimeSpan.FromSeconds(10);
        private IWebDriver driver;

        public Waiters(IWebDriver driver)
        {
            this.driver = driver;
        }

        private WebDriverWait FluentWait(TimeSpan timeOut)
        {
            var wait = new WebDriverWait(driver, timeOut)
            {
                PollingInterval = TimeSpan.FromSeconds(10)
            };
            wait.IgnoreExceptionTypes(
                typeof(NoSuchElementException),
                typeof(ElementNotInteractableException),
                typeof(InvalidElementStateException),
                typeof(StaleElementReferenceException));
            return wait;
        }

        private void WaitForFunction(Func<IWebDriver, bool> condition, TimeSpan timeOut)
        {
            var wait = FluentWait(timeOut);
            wait.Until(condition);
        }


        public void WaitForVisibilityOfWebElement(By by)
        {
            WaitForFunction(driver => driver.FindElement(by).Displayed, timeOut);
        }


        public void WaitToBeClickableOfWebElement(IWebElement element)
        {
            WaitForFunction(driver => element.Displayed && element.Enabled, timeOut);
        }
    }
}

