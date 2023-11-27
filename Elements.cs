using OpenQA.Selenium;

namespace PageObjects
{
    public class Elements
    {
        IWebDriver driver;
        Waiters waiters;

        public Elements(IWebDriver driver)
        {
            this.driver = driver;
            waiters = new Waiters(driver);
        }

        public IWebElement FindElement(By by)
        {
            try
            {
                waiters.WaitForVisibilityOfWebElement(by);
                return driver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return (IWebElement)by;
        }

        public void ClickOnElement(By by)
        {
            IWebElement element = FindElement(by);
            element.Click();
        }

        public void SendKeysToElement(By by, string message)
        {
            IWebElement element = FindElement(by);
            element.SendKeys(message);
        }

        public string GetTextOnElementWithWaiters(By by)
        {
          

                waiters.WaitForVisibilityOfWebElement(by);
                return driver.FindElement(by).Text;
            }

        public string GetTextOnElementString(string text)
        {
            return text;
        }

        public void ClearAll(By by)
        {
            FindElement(by).Clear();
        }

        public void ClickOnElementAfterWaitForClickable(By by)
        {
            IWebElement element = FindElement(by);
            waiters.WaitToBeClickableOfWebElement(element);
            element.Click();
        }

        public int GetValueFromElement(By by)
        {
            IWebElement element = FindElement(by);
            return int.Parse(element.GetAttribute("value"));
        }
    }
}