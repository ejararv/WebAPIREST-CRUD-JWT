using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Testowanie;
using System.IO;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Testowanie.Tests
{

    [TestFixture]
    public class PrzykladTests
    {



        public IWebDriver Driver = new ChromeDriver();


        /* [SetUp]
         public void Initialize()
         {
             Driver.Navigate().GoToUrl("https://localhost:44356/Tokenlog.html");
         }*/



        [OneTimeTearDown]

        public void zakonc()

        {

            Driver.Close();

        }




        [Test]
        public void AngularLogin()
        {
            Driver.Navigate().GoToUrl("http://localhost:4200/login");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//*[@id='username']")).SendKeys("ejararv@gmail.com");
            Driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("6077832Gt");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.Url, Is.EqualTo("http://localhost:4200/"));



        }
        [Test]
        public void AngularLoginEror()
        {
            Driver.Navigate().GoToUrl("http://localhost:4200/login");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//*[@id='username']")).SendKeys("ejararv.com");
            Driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("6077832Gt");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.Url, Is.EqualTo("http://localhost:4200/login"));



        }

        [Test]
        public void AngularUpload()
        {
            Driver.Navigate().GoToUrl("http://localhost:4200/upload");
            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@id='upload']")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.Url, Is.EqualTo("http://localhost:4200/upload"));



        }

        [Test]
        public void AngularLogout()
        {
            Driver.Navigate().GoToUrl("http://localhost:4200/login");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//*[@id='username']")).SendKeys("ejararv@gmail.com");
            Driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("6077832Gt");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@id='logout']")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//*[@id='studenci']")).Click();

            Assert.That(Driver.Url, Is.EqualTo("http://localhost:4200/login"));


        }

        [Test]
        public void CzyUdaSieDodacUzytkownika()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Name("name")).SendKeys("Putin");
            Driver.FindElement(By.Name("age")).SendKeys("60");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(2000);





        }

        [Test]
        public void CzyUdaSieUsunacUzytkownika()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@data-id='44']")).Click();
            System.Threading.Thread.Sleep(2000);



        }

        [Test]
        public void CzyZmienicUzytkownika()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//*[@data-id='44']")).Click();
            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.Name("name")).Clear();
            Driver.FindElement(By.Name("age")).Clear();
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.Name("name")).SendKeys("Trump");
            Driver.FindElement(By.Name("age")).SendKeys("55");
            System.Threading.Thread.Sleep(1000);

            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);


        }

        [Test]
        public void CzyUdaSieDodacUzytkownikaZBłendnymWiekiem()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("Putin");
            Driver.FindElement(By.Name("age")).SendKeys("60.3");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }


        [Test]
        public void CzyUdaSieDodacUzytkownikaZPolskimImiem()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("Miłosz");
            Driver.FindElement(By.Name("age")).SendKeys("20");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }
        [Test]
        public void CzyUdaSieDodacUzytkownikaZRosyjskimImiem()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("Эдуард");
            Driver.FindElement(By.Name("age")).SendKeys("24");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }
        [Test]
        public void CzyUdaSieDodacUzytkownikaBezImie()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("");
            Driver.FindElement(By.Name("age")).SendKeys("60");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }
        [Test]
        public void CzyUdaSieDodacUzytkownikaBezWieku()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("Patryk");
            Driver.FindElement(By.Name("age")).SendKeys("");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }
        [Test]
        public void CzyUdaSieDodacUzytkownika200lat()
        {
            Driver.Navigate().GoToUrl("https://localhost:44356/users.html");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("name")).SendKeys("Stefan");
            Driver.FindElement(By.Name("age")).SendKeys("200");
            Driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            System.Threading.Thread.Sleep(5000);

        }






        /* [Fact]
         public void CzyZadzialaPliczekTekstowy()
         {
             string actual = Przyklad.PrzykladowyPliczek("Scieska do pliku jest prawidlowa.");

             Assert.True(actual.Length > 0);
         }*/
        /*
                [Fact]
                public void ExampleLoadTextFile_InvalidNameShouldFail()
                {
                    Assert.Throws<ArgumentException>("file", () => Przyklad.PrzykladowyPliczek(""));
                }*/
    }
}
