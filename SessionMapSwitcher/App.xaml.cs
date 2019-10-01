﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SessionMapSwitcher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Version GetAppVersion()
        {
            return typeof(SessionMapSwitcher.App).Assembly.GetName().Version;
        }
    }
}
