// using Microsoft.Playwright;
// using NUnit.Framework;
// using System;
// using System.Diagnostics.CodeAnalysis;
// using System.Threading.Tasks;

// namespace PlaywrightProject;

// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }

//     [Test]
//     public async Task Test1()
//     {
//         //playwright
//         using var playwright = await Playwright.CreateAsync();

// //browser
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//         {
//             Headless = false
//         });
// //page
//       var page = await browser.NewPageAsync();
//       await page.GotoAsync("http://www.eaapp.somee.com/");
//       //await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
//        var title =  await page.TitleAsync();
//          Console.WriteLine(title);
//          await page.ClickAsync("text=Visit now");
//         // await page.WaitForLoadStateAsync(LoadState.NetworkIdle);
//         string currentUrl = page.Url;
//          Console.WriteLine(page.Url);
//       await page.CloseAsync();
       
//         Console.WriteLine("Hello World");
//         Assert.Pass();
//     }
// }
