using AutoFrame.Core.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchScratchPageComponent.Pages
{
    public class MatchScratchLoginPage : BasePage
    {
        [FindsBy(How = How.TagName, Using = "button")]
        IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        IWebElement UsernameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "button")]
        IWebElement SubmitLoginButton { get; set; }


    }
}
