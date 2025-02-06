using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AutomationExample
    {
    }
    //public interface IWebDriverFactory
    //{
    //    IWebDriver CreateWebDriver();
    //    DriverOptions CreateOptions();
    //}

    //public class ChromeDriverFactory : IWebDriverFactory
    //{
    //    public IWebDriver CreateWebDriver()
    //    {
    //        return new ChromeDriver(CreateOptions() as ChromeOptions);
    //    }

    //    public DriverOptions CreateOptions()
    //    {
    //        var options = new ChromeOptions();
    //        options.AddArgument("--start-maximized");
    //        return options;
    //    }
    //}

    //public class FirefoxDriverFactory : IWebDriverFactory
    //{
    //    public IWebDriver CreateWebDriver()
    //    {
    //        return new FirefoxDriver(CreateOptions() as FirefoxOptions);
    //    }

    //    public DriverOptions CreateOptions()
    //    {
    //        var options = new FirefoxOptions();
    //        options.AddArgument("--maximized");
    //        return options;
    //    }
    //}

    //// Використання
    //IWebDriverFactory factory = new FirefoxDriverFactory();
    //IWebDriver driver = factory.CreateWebDriver();
}
