﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CalculaImc.Domain.Interfaces;
using CalculaImc.Droid.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseFile))]
namespace CalculaImc.Droid.Database
{
    public class DatabaseFile : IDatabaseFile
    {
        public string GetFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}