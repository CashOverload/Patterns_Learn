using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class AutomationExample
    {
    }

//    public class WebDriverDecorator : IWebDriver
//    {
//        protected IWebDriver _driver;

//        public WebDriverDecorator(IWebDriver driver)
//        {
//            _driver = driver;
//        }

//        public string Url
//        {
//            get => _driver.Url;
//            set
//            {
//                Console.WriteLine($"Navigating to: {value}");
//                _driver.Url = value;
//            }
//        }

//        // Реалізація інших членів інтерфейсу IWebDriver з додаванням логування

//        public void Quit()
//        {
//            Console.WriteLine("Closing the browser");
//            _driver.Quit();
//        }

//        // Інші методи делегуються до _driver або розширюються
//    }

//    // Використання
//    IWebDriver driver = new WebDriverDecorator(new ChromeDriver());
//    driver.Url = "https://www.example.com";
//// Виконання дій
//    driver.Quit();

}
