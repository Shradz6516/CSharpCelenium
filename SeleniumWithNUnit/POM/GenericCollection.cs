﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit
{
    enum PropertyType
    {
        Id,
        Name,
        Class,
        LinkText
    }
    class GenericCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
