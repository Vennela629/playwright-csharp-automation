using System;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightAutomation;

public class LoginTest : PageTest
{
    [SetUp]
    public async Task Setup()
    {
         await Page.GotoAsync("http://www.eaapp.somee.com/");

    }

    [Test]
    public async Task LoginTestCase()
    {
      String actualTitle = await Page.TitleAsync();
         Console.WriteLine($"Page Title: {actualTitle}");
         await Expect(Page).ToHaveTitleAsync("Home - Execute Automation Employee App");
         await Page.ClickAsync("text=Visit now");
        string currentUrl = Page.Url;
         Console.WriteLine(Page.Url);
      await Page.CloseAsync();

       //await Page.ClickAsync("text=Login");


        //Assert.Pass();
    }
}


