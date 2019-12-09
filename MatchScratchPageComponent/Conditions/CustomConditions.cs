using AutoFrame.Core.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Unity.Injection;

namespace MatchScratchPageComponent.Conditions
{
    class CustomConditions : BaseCore
    {
        public static Func<IWebDriver, bool> WaitForBusyMaskToDisappear()
        {
            Logger.Info("Entering " + MethodBase.GetCurrentMethod().Name + ". ");

            Func<IWebDriver, bool> busyMaskCondition = p =>
            {
                var isMaskGone = true;
                try
                {
                    IWebElement mask = Driver.FindElement(By.ClassName("spinner"));

                    if (mask.Displayed)
                    {
                        isMaskGone = false;
                        Logger.Debug("Mask is NOT gone. ");
                    }
                    else
                    {
                        isMaskGone = true;
                        Logger.Debug("Mask is gone. ");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Debug(ex.Message, ex);
                }

                return isMaskGone;
            };

            return busyMaskCondition;
        }

    }
}
