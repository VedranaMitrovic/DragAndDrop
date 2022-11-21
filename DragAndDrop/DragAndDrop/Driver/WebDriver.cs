using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace DragAndDrop.Driver
{
    public static class WebDriver
    {
        public static IWebDriver? Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://demoqa.com/droppable");
        }


        public static void CleanUp()
        {
            Instance?.Quit();
        }

    }
}
