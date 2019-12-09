using AutoFrame.Core.Base;
using AutoFrame.Core.Conditions;
using AutoFrame.Core.Extensions;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchScratchPageComponent.Extensions
{
    public static class Extensions
    {
        public static void WaitForBusyMaskToDisappear(this IWebDriver Driver)
        {
            WaitForBusyMaskToDisappear(Driver, BaseCore.Timeout);
        }

        public static void WaitForBusyMaskToDisappear(this IWebDriver Driver, int timeout)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
          //  wait.Until(CustomConditions.WaitForBusyMaskToDisappear());
        }

        public static void WaitForPopUpMaskToDisappear(this IWebDriver Driver)
        {
            WaitForPopUpMaskToDisappear(Driver, BaseCore.Timeout);
        }

        public static void WaitForPopUpMaskToDisappear(this IWebDriver Driver, int timeout)
        {
            IList<IWebElement> popUpMasks = Driver.FindElements(By.XPath("//*[contains(@class, 'popup-overlay')]"));
            foreach (var popUpMask in popUpMasks)
            {
                Driver.WaitUntilElementIsNotDisplayed(By.ClassName(popUpMask.GetAttribute("class")), timeout);
            }
        }

        public static void WaitForPopUpDialogToDisappear(this IWebDriver Driver)
        {
            WaitForPopUpDialogToDisappear(Driver, BaseCore.Timeout);
        }

        public static void WaitForPopUpDialogToDisappear(this IWebDriver Driver, int timeout)
        {
            Driver.WaitUntilElementIsNotDisplayed(By.ClassName("popup-content "), timeout);
            Driver.WaitUntilElementIsNotDisplayed(By.XPath("//*[contains(@class,'popup-visible')]"), timeout);
            Driver.WaitForPopUpMaskToDisappear(timeout);
        }
    }

    public class ByDataTest : By
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ByDataTest));

        public ByDataTest(string dataTestAttribute)
        {
            FindElementMethod = context =>
            {
                IWebElement element = BaseCore.Driver.FindElement(XPath("//*[@data-test='" + dataTestAttribute + "']"));
                return element;
            };
        }

        public static By DataTest(string dataTestAttribute)
        {
            return XPath("//*[@data-test='" + dataTestAttribute + "']");
        }
    }
}
