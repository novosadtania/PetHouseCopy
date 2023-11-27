
using OpenQA.Selenium;

namespace PageObjects
{
    public class ForDogsPage : BasePage
    {
        public ForDogsPage(IWebDriver driver) : base(driver) { }

        public void OpenPageForDogs()
        {
            driver.Navigate().GoToUrl(Labels.UrlPageForDogs);
        }

        public void ClickOnCheckBoxBrit()
        {
            elements.ClickOnElement(Locators.SelectBrit);
        }

        public void ClickOnCheckBoxJosera()
        {
            elements.ClickOnElement(Locators.SelectJosera);
        }

        public By SelectersIsDisplay()
        {
            return (Locators.SelectorsIsDisplay);
        }

        public void ClickOnButtonBuyOnOneElement()
        {
            elements.ClickOnElement(Locators.ButtonBuyInFirstElement);
        }

        public int BasketAterOneClickBuy()
        {
            return int.Parse(elements.GetTextOnElementWithWaiters(Locators.BasketAfterAddOneGood));
        }

        public void ClickOnButtonAddToCompareSection()
        {
            elements.ClickOnElement(Locators.ButtonAddToCompareSection);
        }

        public By ButtonGoToCompareisDisplay()
        {
            return (Locators.ButtonGoToCompare);
        }

        public void ClickOnNameOfGoodforOpen()
        {
            elements.ClickOnElement(Locators.NameOfGoodForOpen);
        }

        public By DescriptionTextisDIsplay()
        {
            return (Locators.DescriptionText);
        }

        public By SortFormOnPageForDogsIsDisplay()
        {
            return (Locators.SortFormOnPageForDogs);
        }


        private static class Labels
        {
            public const string UrlPageForDogs = "https://pethouse.ua/ua/shop/sobakam/suhoi-korm/";
        }

        private static class Locators
        {
            public static readonly By SelectBrit = By.XPath("//span[text()='Brit Care']");
            public static readonly By SelectJosera = By.XPath("//span[text()='Josera']");
            public static readonly By SelectorsIsDisplay = By.XPath("//div[@class='z2-selected-filters-wrapper']");
            public static readonly By ButtonBuyInFirstElement = By.XPath("//a[@rel='6314,18']");
            public static readonly By BasketAfterAddOneGood = By.XPath("//a/span[@class='quantity small-int']");
            public static readonly By ButtonAddToCompareSection = By.XPath("//div[@data-id='000008596']//span");
            public static readonly By ButtonGoToCompare = By.XPath("//div[@class='cat-compare-added']//span");
            public static readonly By NameOfGoodForOpen = By.XPath("//div[@data-brand='Acana']/a");
            public static readonly By DescriptionText = By.XPath("//div[@id='ph-new-prod-info-block']//span");
            public static readonly By SortFormOnPageForDogs = By.Id("searchSortForm");
        }
    }

}
