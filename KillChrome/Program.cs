﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillChrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"cmd", @"/c taskkill.exe /im:chrome.exe /f");
        }
    }
}