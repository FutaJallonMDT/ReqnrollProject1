using Reqnroll;
using Reqnroll.BoDi;
using ReqnrollProject1.Drivers;

namespace ReqnrollProject1.BaseHooks
{
    [Binding]
    public sealed class Hooks
    {
       public SpecDriver driver;
       public IObjectContainer _ObjectContainer;

        public Hooks (SpecDriver _driver, IObjectContainer container) 
        {
            driver = _driver;
            _ObjectContainer = container;
        }
        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver.InitializedDriver();
            _ObjectContainer.RegisterInstanceAs(driver.driver);
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
          driver.CloseBrowser();
        }
    }
}