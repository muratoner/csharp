namespace MHG.Web.Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrome = new OpenQA.Selenium.Chrome.ChromeDriver { Url = "http://www.google.com" };
            chrome.FindElementById("lst-ib").SendKeys("muratoner.net");
            chrome.FindElementByClassName("lsb").Click();
        }
    }
}