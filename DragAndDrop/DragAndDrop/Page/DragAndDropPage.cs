using OpenQA.Selenium;
using DragAndDrop.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = DragAndDrop.Driver.WebDriver;
using OpenQA.Selenium.Interactions;

namespace DragAndDrop.Page
{
    public class DragAndDropPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Drag => driver.FindElement(By.Id("draggable"));
        public IWebElement Drop => driver.FindElement(By.Id("droppable"));

        public void MoveObject()
        {
            var builder = new Actions(driver);
            var DragAndDrop = builder.ClickAndHold(Drag).MoveToElement(Drop).Release(Drag).Build();
            DragAndDrop.Perform();
        }

    }

}
