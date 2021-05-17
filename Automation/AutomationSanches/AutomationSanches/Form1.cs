using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSanches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String test_url = "https://www.etoro.com/people/sanchessls/portfolio";
            IWebDriver driver;

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();


            driver.Url = test_url;

            System.Threading.Thread.Sleep(5000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[id = 'mytable4']"));

            IList<IWebElement> tableRow = searchText.FindElements(By.TagName("tr"));

            var a = tableRow.Last();

            var b = a.FindElements(By.TagName("th"));

            MessageBox.Show(b[9].Text);


            Console.WriteLine("Test Passed");


            driver.Quit();
        }
    }
}
