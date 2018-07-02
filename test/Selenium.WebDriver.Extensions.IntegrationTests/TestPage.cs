namespace Selenium.WebDriver.Extensions.IntegrationTests
{
    using JetBrains.Annotations;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Diagnostics.CodeAnalysis;

    [PublicAPI]
    [ExcludeFromCodeCoverage]
    internal class TestPage
    {
        [FindsBy(How = How.Custom, CustomFinderType = typeof(JQuerySelector), Using = "h1")]
        public IWebElement HeadingJQuery { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(SizzleSelector), Using = "h1")]
        public IWebElement HeadingSizzle { get; set; }
    }
}
