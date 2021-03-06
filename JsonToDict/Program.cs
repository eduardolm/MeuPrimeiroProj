﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonToDict
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{'href': '/account/login.aspx','target': '_blank'}";

            Dictionary<string, string> htmlAttributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            Console.WriteLine(htmlAttributes["href"]);
            // /account/login.aspx

            Console.WriteLine(htmlAttributes["target"]);
            // _blank
        }
    }
}