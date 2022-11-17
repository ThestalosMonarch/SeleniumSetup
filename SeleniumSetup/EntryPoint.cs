// Selenium test with c#

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSetup;

IWebDriver driver = new ChromeDriver();

driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/"); // abrir navegador na página específica

IWebElement element = null;
string name = "myName";
string id = "testImage";
string className = "testClass";
string cssPath = "#post-108 > div > figure > img";
string xPath = "//*[@id=\"post-109\"]/div/figure/img";
//achar pelo nome
FindSelectors selectors = new FindSelectors();
selectors.SelectorByName(element, driver, name);
//achar pelo ID
driver.Navigate().GoToUrl("https://testing.todorvachev.com/id/");
selectors.SelectorByID(element, driver, id);
//achar pelo selector className
driver.Navigate().GoToUrl("https://testing.todorvachev.com/class-name/");
selectors.SelectorByClassName(element, driver, className);
//achar pelo selector css 
driver.Navigate().GoToUrl("https://testing.todorvachev.com/css-path/");
selectors.SelectorByCSSPath(element, driver, cssPath);
//achar pelo selector xPath 
driver.Navigate().GoToUrl("https://testing.todorvachev.com/xpath/");
selectors.SelectorByXPath(element, driver, xPath);



driver.Quit(); //fechar o site;

