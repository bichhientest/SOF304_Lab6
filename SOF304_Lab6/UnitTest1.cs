
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SOF304_Lab6
{
    public class Tests
    {
        private IWebDriver driver;
        private string url = @"file:///C:/Users/LENOVO/Downloads/Webautomation/Webautomation/valildate.html";
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Testcase1()
        {
           IWebElement usernameElement=driver.FindElement(By.Id("uname"));
            //usernameElement.SendKeys("Bhien");
            IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
           // passwordElement.SendKeys("12345");
            IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
            checkboxElement.Click();
            Thread.Sleep(1000);
            IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
            submitElement.Click();

            string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(3);
            Assert.That( driver.Url,Is.EqualTo(expectedUrl));
        }
		[Test]
		public void Testcase2()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			//usernameElement.SendKeys("Bhien");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("12345");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase3()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			//usernameElement.SendKeys("Bhien");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("123");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase4()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhien");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			//passwordElement.SendKeys("1234");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase5()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhien");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("12345");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase6()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhien");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("123");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase7()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhi");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			//passwordElement.SendKeys("123");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase8()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhi");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("12345");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[Test]
		public void Testcase9()
		{
			IWebElement usernameElement = driver.FindElement(By.Id("uname"));
			usernameElement.SendKeys("Bhi");
			IWebElement passwordElement = driver.FindElement(By.Id("pwd"));
			passwordElement.SendKeys("123");
			IWebElement checkboxElement = driver.FindElement(By.Id("myCheck"));
			checkboxElement.Click();
			Thread.Sleep(1000);
			IWebElement submitElement = driver.FindElement(By.ClassName("btn-primary"));
			submitElement.Click();

			string expectedUrl = "file:///C:/action_page.php?uname=Bhien&pswd=12345&remember=on";
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
			Assert.That(driver.Url, Is.EqualTo(expectedUrl));
		}
		[TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Quit();

        }

    }
}