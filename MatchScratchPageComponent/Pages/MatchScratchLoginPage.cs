using AutoFrame.Core.Base;
using AutoFrame.Core.Extensions;
using MatchScratchPageComponent.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MatchScratchPageComponent.Pages
{

    
    public class MatchScratchLoginPage : BasePage
    {

        string emailAddress = "mrfootie5@mailinator.com";

        [FindsBy(How = How.TagName, Using = "button")]
        IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Name, Using = "Username")]
        IWebElement UsernameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "button")]
        IWebElement SubmitLoginButton { get; set; }

        public void ClickLoginButton()
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");

            Driver.WaitForBusyMaskToDisappear();
            Driver.WaitUntilElementIsClickable(LoginButton);
            Driver.WaitForBusyMaskToDisappear();
            LoginButton.Click();
            Driver.WaitForBusyMaskToDisappear();

            Logger.Info("Exiting " + MethodBase.GetCurrentMethod().Name + ". ");

        }

        public void EnterEmailAddressTextBoxValue(string emailAddress)
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            Driver.WaitForBusyMaskToDisappear();
            Driver.WaitUntilElementIsClickable(UsernameTextBox);
            Driver.WaitForBusyMaskToDisappear();
            UsernameTextBox.SendKeys(emailAddress); // Enter Username or Email Address
            Driver.WaitForBusyMaskToDisappear();

            Logger.Info("Exiting " + MethodBase.GetCurrentMethod().Name + ". ");
        }

        public void EnterPasswordTextBoxValue(string password)
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");

            Driver.WaitForBusyMaskToDisappear();
            Driver.WaitUntilElementIsClickable(PasswordTextBox);
            Driver.WaitForBusyMaskToDisappear();
            PasswordTextBox.SendKeys(password); // Enter Password
            Driver.WaitForBusyMaskToDisappear();

            Logger.Info("Exiting " + MethodBase.GetCurrentMethod().Name + ". ");

        }

        public void ClickSubmitLoginButton()
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");

            Driver.WaitForBusyMaskToDisappear();
            Driver.WaitUntilElementIsClickable(SubmitLoginButton);
            Driver.WaitForBusyMaskToDisappear();
            LoginButton.Click();
            Driver.WaitForBusyMaskToDisappear();

            Logger.Info("Exiting " + MethodBase.GetCurrentMethod().Name + ". ");

        }
    }
}
