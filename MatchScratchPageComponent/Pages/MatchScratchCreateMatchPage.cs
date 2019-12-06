using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchScratchPageComponent.Pages
{
    class MatchScratchCreateMatchPage
    {
        [FindsBy(How = How.Name, Using = "gameType")]
        IWebElement GameTypeDropDownMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='1']")]
        IWebElement SelectFootballOptionDropDownMenu { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement CreateRoundGoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='mat-form-field-suffix ng-tns-c4-0 ng-star-inserted']")]
        IWebElement CreateRoundStartDateButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='26 December 2019']")]
        IWebElement CreateRoundStartDateSelection { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement CreateRoundDateGoButton { get; set; }

        [FindsBy(How = How.Id, Using = "btnSelect")]
        IWebElement SelectFixturesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > app-root > content-layout > div > div > div.col-sm-9.body-content > create-round > app-league-selector > div > div:nth-child(2) > input")]
        IWebElement DailyServiceTickBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > app-root > content-layout > div > div > div.col-sm-9.body-content > create-round > app-league-selector > div > div:nth-child(4) > app-fixture-list > div.fixtureListMainDiv > div.scroll-box.fixtureList.mb-5 > ul:nth-child(1) > li:nth-child(4) > input")]
        IWebElement FixtureSelectionTickBox { get; set; }

        [FindsBy(How = How.Id, Using = "btnGo")]
        IWebElement CreateMarketGoButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > app-root > content-layout > div > div > div.col-sm-9.body-content > create-round > app-matchdistribution-list > div > a")]
        IWebElement RandomExpectationLink { get; set; }

        [FindsBy(How = How.Name, Using = "season")]
        IWebElement SeasonDropDownMenu { get; set; }

    }
}
