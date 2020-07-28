using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;

namespace selenuimmm
{
    public partial class Form1 : Form
    {
        public object driver;
        ChromeDriver chromeDriver = new ChromeDriver();
        public Form1()
        {
            InitializeComponent();
        }


        public void login(ChromeDriver chromeDriver)
        {
         
                    chromeDriver.Url = "https://www.facebook.com/";
                    chromeDriver.Navigate();
                    var username = chromeDriver.FindElementById("email");
                    username.SendKeys(tk.Text);

                    var password = chromeDriver.FindElementById("pass");
                    password.SendKeys(mk.Text);

                    var login = chromeDriver.FindElementById("u_0_b");
                    login.Click();
                    Thread.Sleep(500);
                }
            
      
        public void post(ChromeDriver chromeDriver)
        {
          
            var postBox = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]");
            Thread.Sleep(10000);
            postBox.Click();
            Thread.Sleep(1000);
            postBox.SendKeys(ndpost.Text);
            Thread.Sleep(5000);
            var posttt = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[4]/div/div[2]/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[3]/div[2]/div");
            Thread.Sleep(5000);
            posttt.Click();
           
        }
        public void share(ChromeDriver chromeDriver)
        {
            try
            {
                chromeDriver.Url = url.Text;
                Thread.Sleep(10000);
                var sshare = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[3]/div/div");
                sshare.Click();
                Thread.Sleep(1000);
                var sharenow = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div/div[1]/div/div/div[1]/div[1]/div[2]/div/div");
                sharenow.Click();
            }
            catch(Exception e)
            {
                lbError.Text = "Không thể Share!";
                lbError.Visible = true;
            }
        }
        public void share2(ChromeDriver chromeDriver)
        {
            chromeDriver.Url = url.Text;
            Thread.Sleep(5000);
            var timshare = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div/div/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[3]/div/div");
            timshare.Click();
            Thread.Sleep(1000);
            var ss = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div/div[1]/div/div/div[1]/div[2]");
            ss.Click();
            Thread.Sleep(1000);
            var v = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[2]/div[1]/div[1]/div[1]/div/div/div/div/div[2]/div/div/div/div");
            v.SendKeys("l");
            Thread.Sleep(500);
            var sb = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div[2]/div[3]/div[1]/div");
            sb.Click();
        }
        public void likenh(ChromeDriver chromeDriver)
        {
            // var likee = chromeDriver.FindElementsByXPath("//div[@aria-label='Thích']");
            for(int i =1;i<= solanLike.Value; i++)
            {
                var likee = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div["+i+"]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div");
                likee.Click();
                Thread.Sleep(500);
            }
            
            /*/var like2 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[4]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div/div");
            like2.Click();
            Thread.Sleep(500);
            var like3 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[5]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div/div");
            like3.Click();
            Thread.Sleep(500);
            var like4 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[6]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div/div");
            like4.Click();
            Thread.Sleep(500);
            var like5 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[8]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div");
            like5.Click();
            Thread.Sleep(500);
            var like6 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[11]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div/div[2]/div/span[1]/div/div/span/div");
            like6.Click();
            Thread.Sleep(500);
            var like7 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[12]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div/div[2]/div/span[1]/div/div/span/div");
            like7.Click();
            Thread.Sleep(500);
            var like8 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[13]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div");
            like8.Click();
            Thread.Sleep(500);
            var like9 = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div/div[4]/div[2]/div/div[2]/div[2]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div[2]/div/span[1]/div/div/span/div");
            like9.Click();
            Thread.Sleep(500);/*/
        }

        public void comment(ChromeDriver chromeDriver)
        {
            for(int i =1;i<= soluotComment.Value; i++)
            {
                try
                {
                    var cmt = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[" + i + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[2]/div[5]/div[2]/div/div/div/div/form/div/div/div[2]/div");
                    cmt.Click();
                    cmt.SendKeys(comm.Text);
                    Thread.Sleep(2000);
                    cmt.SendKeys(Keys.Enter);
                }
                catch(Exception e)
                {
                    var hihi = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[" + i + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div/div[2]/div/span[2]/div");
                    hihi.Click();
                    Thread.Sleep(3000);
                    var cmt = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[" + i + "]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[2]/div[3]/div[2]/div/div/div/div/form/div/div/div[2]/div/div/div/div");
                    cmt.Click();
                    Thread.Sleep(5000);
                    cmt.SendKeys(comm.Text);
                    Thread.Sleep(2000);
                    cmt.SendKeys(Keys.Enter);
                }
            }
            
        }
        private void like_Click(object sender, EventArgs e)
        {
           
            var botlike = chromeDriver.FindElementByXPath("/html/body/div[1]/div/div/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div/div/div[3]/div/div[4]/div/div[1]/div/div/div/div/div/div/div/div/div/div/div[2]/div/div[4]/div/div/div[1]/div/div/span[1]/div/div/span/div");
            botlike.Click();
        }
        private void start_Click(object sender, EventArgs e)
        {
            login(chromeDriver);
        }

        private void postt_Click(object sender, EventArgs e)
        {
            post(chromeDriver);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            share(chromeDriver);
        }

        private void cmtt_Click(object sender, EventArgs e)
        {
            comment(chromeDriver);
        }

        private void csvb_Click(object sender, EventArgs e)
        {
            share2(chromeDriver);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            likenh(chromeDriver);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comment(chromeDriver);
        }

        private void tk_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }
    }

}
