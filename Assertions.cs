using OpenQA.Selenium;
using NUnit.Framework;

namespace PageObjects
{
    public class Assertions
    {
        private IWebDriver driver;
        private Elements elements;
        private Waiters waiters;
        private Action action;

        public Assertions(IWebDriver driver)
        {
            this.driver = driver;
            elements = new Elements(driver);
            waiters = new Waiters(driver);
            action = new Action(driver);
        }

        public void EqualsText(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Console.WriteLine($"Очікувалося отримати текст: \"{expected}\", а отримано: \"{actual}\".");
                throw;
            }
        }
        public void СontaintsText(String actual, String expected)
        {
            Assert.IsTrue(expected.Contains(actual));
        }

        public void ElementIsDisplay(By by)
        {
            Assert.IsTrue(elements.FindElement(by).Displayed);
        }


        public void EqualsInt(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }
        }
    }
