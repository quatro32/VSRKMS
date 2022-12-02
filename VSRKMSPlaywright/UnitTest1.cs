using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using static System.Net.WebRequestMethods;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    private readonly string url = @"http://localhost:5283/";
    //[Test]
    //public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    //{
    //    await Page.GotoAsync("https://localhost:7283/");

    //    // Expect a title "to contain" a substring.
    //    await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

    //    // create a locator
    //    var getStarted = Page.GetByRole(AriaRole.Link, new() { NameString = "Get started" });

    //    // Expect an attribute "to be strictly equal" to the value.
    //    await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

    //    // Click the get started link.
    //    //await getStarted.ClickAsync();

    //    // Expects the URL to contain intro.
    //    await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
    //}

    [Test]
    public async Task TestIfAllCountersAreZeroAtStart()
    {
        //navigate to app
        await Page.GotoAsync(url);

        await Page.GetByRole(AriaRole.Cell, new() { NameString = "Fontys Venlo" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() { NameString = "Meting starten" }).ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { NameString = "0.11 Kantoor accounting internationaal Bureau" }).GetByRole(AriaRole.Cell, new() { NameString = "Kantoor accounting internationaal" }).ClickAsync();

        var allCounterValues = await Page.Locator(".hiddenElementCount").AllInnerTextsAsync(); 
    }

    [Test]
    public async Task OpensAuditWhenClickAuditPreview()
    {
        //navigate to app
        await Page.GotoAsync(url);

        //save clicked project in auditpreview to assert value later
        var auditListProject = Page.GetByRole(AriaRole.Cell, new() { NameString = "Dependance VSR" });

        //save projectname for assertion later
        string? auditListProjectName = await auditListProject.InnerTextAsync();

        //navigate by clicking auditproject
        await auditListProject.ClickAsync();

        //assert if current page is right page
        await Expect(Page).ToHaveURLAsync(url + "AuditMain");

        //get shown project name on audit page
        string? shownProjectNameOnPage = await Page.GetByRole(AriaRole.Heading, new() { NameString = "Project: Dependance VSR" }).InnerTextAsync();

        //assert if name on index is same as on auditpage
        StringAssert.Contains(auditListProjectName, shownProjectNameOnPage);
    }

    [Test]
    public async Task CheckIfAuditCloseButtonWorks()
    {
        //navigate to app
        await Page.GotoAsync(url);

        //open audit, by clicking on one in list
        await Page.GetByRole(AriaRole.Cell, new() { NameString = "Dependance VSR" }).ClickAsync();

        //assert if current page is right page
        await Expect(Page).ToHaveURLAsync(url + "AuditMain");

        //click on close audit button
        await Page.GetByRole(AriaRole.Button, new() { NameString = "Meting afsluiten" }).ClickAsync();

        //assert if url is same as start url
        await Expect(Page).ToHaveURLAsync(url);
    }

        [Test]
    public async Task OpenAuditAndRoomListIsNotEmpty()
    {
        //navigate to app
        await Page.GotoAsync(url);
        
        //open audit, by clicking on one in list
        await Page.GetByRole(AriaRole.Cell, new() { NameString = "Dependance VSR" }).ClickAsync();

        //start audit by clicking button
        await Page.GetByRole(AriaRole.Button, new() { NameString = "Meting starten" }).ClickAsync();

        //get table value
        var tableHtml = await Page.GetByRole(AriaRole.Table, null).InnerTextAsync();

        //assert table value 
        Assert.IsNotEmpty(tableHtml);
    }
}