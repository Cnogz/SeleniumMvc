using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        //Uygun driver eklenmelidir.
        /*
        using OpenQA.Selenium.Firefox;
        using OpenQA.Selenium.IE;
        using OpenQA.Selenium.Chrome;
         */

        //C klasörüne altta belirtilen klasörler açılmalıdır ve içerisine indirilen driverlar atılmalıdır.
        //Driver indirme linkleri ReadMe.txt içerisinde mevcuttur.

        //chrome için driver yolu
        //private const string CHROME_DRIVER_PATH = @"C:\ChromeDriver";
        //ie için driver yolu
        private const string IE_DRIVER_PATH = @"C:\SeleniumDriver";

        //Ekran görüntülerini jpeg olarak saklayacak bir klasör açıyoruz.
        private const string ScreenShotLocation = @"C:\ScreenShot";


        [TestMethod]
        public void Get()
        {
            IWebDriver driver = null;
            
                //IE için
                driver = new InternetExplorerDriver(IE_DRIVER_PATH);
                //Chrome için
                //driver = new ChromeDriver(CHROME_DRIVER_PATH);

                //MVC Projemizin url'ini girmeliyiz.
                driver.Navigate().GoToUrl("http://localhost:49920/");

                //Testi gerçekleştirmek için.
                TestAddProduct(driver);
           
                //Browser quit metodu çalıştırılınca kapanacaktır.
                driver.Quit();
            
        }

        //Metodun üzerindeki alandan run tests tıklanarak çalıştırılır.
        private void TestAddProduct(IWebDriver driver)
        {
            
            //Add metodunu test ediyoruz
            driver.FindElement(By.Id("Add")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Elementlerin yüklendiğinden emin olmak için Name id'li ilk textbox yüklenene kadar beklıyoruz.
            wait.Until((d) => { return d.FindElement(By.Id("Name")); });


          

            //Web elementleri yakalanır. ID üzerinden yakalıyoruz.
            IWebElement name = driver.FindElement(By.Id("Name"));
            IWebElement unitPrice = driver.FindElement(By.Id("UnitPrice"));
            IWebElement unitsInStock = driver.FindElement(By.Id("UnitsInStock"));
            IWebElement submit = driver.FindElement(By.Id("Submit"));

            
            //Örnek verilerle deneme.
            name.SendKeys("Kola");
            unitPrice.SendKeys("50");
            unitsInStock.SendKeys("80");
            
          
            //Submit butonuna tıklama
            submit.Click();



            //Ekran görüntüsü yakalama ve kaydetme işlemleri
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(ScreenShotLocation + "\\" + "Add" + "ProductAdd.jpeg", ScreenshotImageFormat.Jpeg);

        }

       
           
          
        
    }
}
