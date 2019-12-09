using System;
using System.Collections.Generic;
using System.Reflection;
using AutoFrame.Core.Base;
using AutoFrame.Core.Extensions;
using MatchScratchPageComponent.Extensions;
using MatchScratchPageComponent.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace MatchScratchPageComponent.Panels
{
    public abstract class AbstractRightPanel : AbstractLeftPanel
    {
        protected T ClickButton<T>(IWebElement buttonElement) where T : BasePage, new()
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");

            Driver.WaitForBusyMaskToDisappear();
            Driver.WaitUntilElementIsClickable(buttonElement);
            Driver.WaitForBusyMaskToDisappear();
            buttonElement.Click();
            Driver.WaitForBusyMaskToDisappear();

            return GetPage<T>();
        }


      

    }
}
