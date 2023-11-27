using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjects;
using Action = PageObjects.Action;

namespace PetHouseCopy
{
    /* public class DriverFactory
     {
         private static IWebDriver driver;
         private static Waiters wait;
         private static Action action;
         private static Assertions assertions;
         private static Elements elements;

         private static IWebDriver SetUpDriver()
         {
             try
             {
                 // Ініціалізація драйвера Chrome
                 driver = new ChromeDriver();

                 // Максимізація вікна
                 driver.Manage().Window.Maximize();

                 // Налаштування таймауту для неявного очікування (Implicit Wait)
                 driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                 // Ініціалізація об'єктів для роботи з очікуваннями, елементами та ін.
                 wait = new Waiters(driver);
                 action = new Action(driver);
                 assertions = new Assertions(driver);
                 elements = new Elements(driver);

                 return driver;
             }
             catch (Exception ex)
             {
                 // Обробка винятків тут або просто перекинення його далі
                 throw new Exception("Помилка при ініціалізації драйвера", ex);
             }
         }

         public static IWebDriver StartChromeDriver()
         {
             if (driver == null)
             {
                 driver = SetUpDriver();
             }
             return driver;
         }
     }
 }*/
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> threadLocalDriver = new ThreadLocal<IWebDriver>();
        private static ThreadLocal<Waiters> threadLocalWait = new ThreadLocal<Waiters>();
        private static ThreadLocal<Action> threadLocalAction = new ThreadLocal<Action>();
        private static ThreadLocal<Assertions> threadLocalAssertions = new ThreadLocal<Assertions>();
        private static ThreadLocal<Elements> threadLocalElements = new ThreadLocal<Elements>();

        private static IWebDriver SetUpDriver()
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                // Додаткові налаштування опцій (за потреби)

                IWebDriver driver = new ChromeDriver(options);

                // Інші можливі налаштування драйвера
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                return driver;
            }
            catch (Exception ex)
            {
                // Обробка винятків тут або просто перекинення його далі
                throw new Exception("Помилка при ініціалізації драйвера", ex);
            }
        }

        public static IWebDriver StartChromeDriver()
        {
            if (!threadLocalDriver.IsValueCreated)
            {
                threadLocalDriver.Value = SetUpDriver();
                threadLocalWait.Value = new Waiters(threadLocalDriver.Value);
                threadLocalAction.Value = new Action(threadLocalDriver.Value);
                threadLocalAssertions.Value = new Assertions(threadLocalDriver.Value);
                threadLocalElements.Value = new Elements(threadLocalDriver.Value);
            }
            return threadLocalDriver.Value;
        }

        public static void QuitDriver()
        {
            if (threadLocalDriver.IsValueCreated)
            {
                threadLocalDriver.Value.Quit();
                threadLocalDriver.Dispose();
            }
        }

        public static Waiters GetWaiters()
        {
            return threadLocalWait.Value;
        }

        public static Action GetAction()
        {
            return threadLocalAction.Value;
        }

        public static Assertions GetAssertions()
        {
            return threadLocalAssertions.Value;
        }

        public static Elements GetElements()
        {
            return threadLocalElements.Value;
        }
    }
}