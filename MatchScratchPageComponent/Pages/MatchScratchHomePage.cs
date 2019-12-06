using AutoFrame.Core.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchScratchPageComponent.Pages
{
    public class MatchScratchHomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@href='/create']")]
        IWebElement CreateRoundLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href='/view/rounds']")]
        IWebElement ViewRoundLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@href='/wagers/validate']")]
        IWebElement ValidateWagersLink { get; set; }
    }
}
