using Microsoft.WindowsAzure.MobileServices;
using System;

using Xamarin.Forms;
using XamarinAllianceApp.Models;
using XamarinAllianceApp.Views;

namespace XamarinAllianceApp
{
	public class App : Application
	{
        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App ()
		{
            // The root page of your application
            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new CharacterListPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

