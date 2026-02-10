using System;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
//using Microsoft.Playwright.Transport.Protocol;
//using NUnit.Framework;

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
      String pageTitle = await Page.TitleAsync();
         Console.WriteLine($"Page Title: {pageTitle}");
         await Expect(Page).ToHaveTitleAsync("Home - Execute Automation Employee App");
        //  await Page.ClickAsync("text=Visit now");
        // string currentUrl = Page.Url;
        //  Console.WriteLine(Page.Url);

        var lnklogin = Page.Locator("text=Login"); //01 - one way of using locator
        await lnklogin.ClickAsync();
        //await Page.ClickAsync("text=Login");       
        await Page.FillAsync("#UserName", "admin");
        Console.WriteLine($"Username is Entered");
        await Page.FillAsync("#Password", "password");
        Console.WriteLine($"Password is Entered");

        //02 - another way of using locators
        var btnlgn = Page.Locator(
            "input", new PageLocatorOptions{HasTextString="Log in"}
        );
        await btnlgn.ClickAsync();

        //await Page.ClickAsync("text=Log in");
        string currentUrl = Page.Url;
        Console.WriteLine($"Loggedin url is :{Page.Url}");
        await Expect(Page.Locator("text='Courses'")).ToBeVisibleAsync();
         Console.WriteLine($"User Logged in Successfully");

      await Page.CloseAsync();

       


        //Assert.Pass();
    }
}


