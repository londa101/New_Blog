﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Blog.Pages
{
    public class BasePage
    {
       
            private IWebDriver driver;
            private WebDriverWait wait;

            public BasePage(IWebDriver driver)
            {
                this.driver = driver;
                this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            }

            public IWebDriver Driver
            {
                get
                {
                    return this.driver;
                }
            }

            public WebDriverWait Wait
            {
                get
                {
                    return this.wait;
                }
            }
        }   
}