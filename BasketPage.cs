using OpenQA.Selenium;

namespace PageObjects
{
    public class BasketPage : BasePage
    {
        public BasketPage(IWebDriver driver) : base(driver) {}

        public void OpenBasketPage()
        {
                driver.Navigate().GoToUrl(Labels.UrlPageOfBasket);
        }

        public By OneGoodInBasketVerifyIsDisplay()
        {
            return (Locators.OneGoodInBasketToVerify);
        }

        public By SectionYourPetWillLikeIsDisplay()
        {
            return (Locators.SectionYourPetWillLikeIbBasket);
        }

        public void ClickOnButtonDelete()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.ButtonDeleteInBasket);
        }

        public void ClickOnButtonPlus(int countOfNumber)
        {
            for (int i = 0; i < countOfNumber; i++)
            {
                elements.FindElement(Locators.ButtonPlusInBasket).Click();
            }
        }

        public int getValueFromBoxOfNumbersAddedGoods()
        {
            return elements.GetValueFromElement(Locators.BoxOfNumbersAddedGoodInBasket);

        }

        public By ButtonSubmitDisplay()
        {
            return (Locators.ButtonSubmitInBasket);
        }

        public By InformationEmptyShoppingCartIsDisplay()
        {
            return (Locators.InformationEmptyShoppingCart);
        }

        public void ClickOnButtonMinus(int countOfNumber)
        {
            for (int i = 0; i < countOfNumber; i++)
            {
                elements.FindElement(Locators.ButtonMinusInBasket).Click();
            }
        }

        public By informationToLoginInBasketIsDisplay()
        {
            return (Locators.InformationToLoginInBasket);
        }


        private static class Labels
        {
            public const string UrlPageOfBasket = "https://pethouse.ua/ua/basket/";
        }

        private static class Locators
        {
            public static readonly By OneGoodInBasketToVerify = By.XPath("//div[@class='header-cart']/a/span[text()='1']");
            public static readonly By SectionYourPetWillLikeIbBasket = By.Id("basket-cross-wrapper-over");
            public static readonly By ButtonDeleteInBasket = By.XPath("//a[@class='tpl-dell']");
            public static readonly By ButtonSubmitInBasket = By.Id("submit");
            public static readonly By ButtonPlusInBasket = By.Id("tpl_basket-num-inc");
            public static readonly By ButtonMinusInBasket = By.Id("tpl_basket-num-dec");
            public static readonly By BoxOfNumbersAddedGoodInBasket = By.XPath("//input[@class='tpl-basket-num']");
            public static readonly By InformationToLoginInBasket = By.XPath("//div[@class='basket-new-address-login']");
            public static readonly By InformationEmptyShoppingCart = By.XPath("//div[@class='ph-big-cat-little-header']");

        }
    }
}
