using DragAndDrop.Driver;
using DragAndDrop.Page;

namespace DragAndDrop
{
    public class Tests
    {
        DragAndDropPage DragAndDrop;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            DragAndDrop = new DragAndDropPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }

        [Test]
        public void Test1()
        {
            DragAndDrop.MoveObject();
        }

        
    }
}