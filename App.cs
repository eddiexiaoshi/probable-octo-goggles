﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinForms.SQLite.SQLite;
using SQLite;

using Xamarin.Forms;

namespace Project2
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //MainPage = new NavigationPage(new Homepage());

            MainPage = new NavigationPage(new MenuPage());
       
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}