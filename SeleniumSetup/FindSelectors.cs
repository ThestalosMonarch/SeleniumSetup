using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSetup
{
    //encontra os seletores com base em Nome,ID, Class Name, CSS e XPath
    public class FindSelectors
    {

        public void SelectorByName(IWebElement element, IWebDriver driver, string name)
        {
            element = driver.FindElement(By.Name(name));
            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element");
                Console.WriteLine(element.Text);
            }
            else
            {
                RedMessage("I can´t see the element");
            }
        }
        public void SelectorByID(IWebElement element, IWebDriver driver, string id)
        {
            element = driver.FindElement(By.Id(id));
            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element");
                Console.WriteLine(element.Text);
            }
            else
            {
                RedMessage("I can´t see the element");
            }
        }
        public void SelectorByClassName(IWebElement element, IWebDriver driver, string className)
        {
            element = driver.FindElement(By.ClassName(className));
            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element");
                Console.WriteLine(element.Text);
            }
            else
            {
                RedMessage("I can´t see the element");
            }
        }
        public void SelectorByCSSPath(IWebElement element, IWebDriver driver, string cssPath)
        {
            element = driver.FindElement(By.CssSelector(cssPath));
            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element");
                Console.WriteLine(element.Text);
            }
            else
            {
                RedMessage("I can´t see the element");
            }
        }
        public void SelectorByXPath(IWebElement element, IWebDriver driver, string XPath)
        {
            element = driver.FindElement(By.XPath(XPath));
            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element");
                Console.WriteLine(element.Text);
            }
            else
            {
                RedMessage("I can´t see the element");
            }
        }
        void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
