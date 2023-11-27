using OpenQA.Selenium;

namespace PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver){ }
        
        
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Labels.Url);
        }

        public void ClickOnButtonLanguageUkr()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.ButtonLanguageUkr);
        }

        public void ClickOnButtonLanguageRuss()
        {
            elements.ClickOnElement(Locators.ButtonLanguageRuss);
        }

        public void SendKeysToElementNameOfBrends()
        {
            elements.SendKeysToElement(Locators.SearchLine, Labels.NameOfBrends);
        }

        public void SendKeysToElementNameOfGoods()
        {
            elements.SendKeysToElement(Locators.SearchLine, Labels.NameOfGoods);
        }

        public void SendKeysToElementNotVariableText()
        {
            elements.SendKeysToElement(Locators.SearchLine, Labels.NotVariableText);
        }

        public string TextOnElementsAfterTranslateFromLocators()
        {
            return elements.GetTextOnElementWithWaiters(Locators.TextAfterTranslate);
        }

        public string TextOnElementsAfterTranslateFromLabels()
        {
            return elements.GetTextOnElementString(Labels.TextToTranslate);
        }

        public string TextOnElementsAfterWritingBrends()
        {
            return elements.GetTextOnElementWithWaiters(Locators.DropdownResultShopAllFromSearch);
        }

        public string TextOnElementsAfterWritingBrendsLabels()
        {
            return elements.GetTextOnElementString(Labels.TextShowAll);
        }

        public string TextOnElementsAfterWritingGoods()
        {
            return elements.GetTextOnElementWithWaiters(Locators.DropdownResultShopAllFromSearch);
        }

        public string TextOnElementsAfterWritingGoodsLabels()
        {
            return elements.GetTextOnElementString(Labels.TextShowAll);
        }

        public string TextOnElementsAfterWritingRandom()
        {
            return elements.GetTextOnElementWithWaiters(Locators.DropdownResultNothingNotFoundFromSearch);
        }

        public string TextOnElementsAfterWritingRandomLabels()
        {
            return elements.GetTextOnElementString(Labels.StringNothing);
        }

        public By DropdownForDogsIsDisplay()
        {
            return Locators.DropdownForDogs;
        }

        public By ButtonLanguageRussIsDisplay()
        {
            return Locators.ButtonLanguageRuss;
        }

        public By DropdownAfterWritingAnythingInLineSearchIsDisplay()
        {
            return Locators.DropdownAfterWritingAnythingInLineSearch;
        }

        public By LineForDogs()
        {
            return Locators.SectionLineForDogs;
        }

        public void ClearLineSearch()
        {
            elements.ClearAll(Locators.SearchLine);
        }

        private static class Labels
        {
            public const string Url = "https://pethouse.ua/";
            public const string TextToTranslate = "Кошик";
            public const string NameOfBrends = "Natural";
            public const string NameOfGoods = "rope";
            public const string NotVariableText = "qwerty";
            public const string TextShowAll = "Показати усі";
            public const string StringNothing = "Нічого";
        }

        private static class Locators
        {
            public static readonly By SectionLineForDogs = By.XPath("//li[@id='tpl-top-menu-first-li-1']/a");
            public static readonly By DropdownForDogs = By.XPath("//ul[@style='display: block;']");
            public static readonly By ButtonLanguageUkr = By.XPath("//a[@href='https://pethouse.ua/ua/']");
            public static readonly By ButtonLanguageRuss = By.XPath("//a[@href='https://pethouse.ua/ru/']");
            public static readonly By TextAfterTranslate = By.XPath("//span[@class='hide-for-tablet']");
            public static readonly By SearchLine = By.Id("search");
            public static readonly By DropdownResultShopAllFromSearch = By.XPath("//div[@class= 'itm-other']");
            public static readonly By DropdownResultNothingNotFoundFromSearch = By.XPath("//div[@id='search-box']/div/span");
            public static readonly By DropdownAfterWritingAnythingInLineSearch = By.Id("search-box");
        }
    }
}