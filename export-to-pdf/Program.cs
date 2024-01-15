// Setup Puppeteer to use the correct version of Chromium.

using PuppeteerSharp;

await new BrowserFetcher().DownloadAsync();

// Launch the browser and navigate to the page
using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
using var page = await browser.NewPageAsync();
await page.GoToAsync("http://family-budget.com.ua/sign-in");

// Export the page to PDF
await page.PdfAsync("export.pdf");