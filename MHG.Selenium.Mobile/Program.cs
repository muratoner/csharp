using OpenQA.Selenium.Chrome;

namespace MHG.Selenium.Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.EnableMobileEmulation("Nexus 7");
            using (var chromeMobile = new ChromeDriver(chromeOptions))
            {
                chromeMobile.Navigate().GoToUrl("https://www.instagram.com");
            }
        }
    }
}
