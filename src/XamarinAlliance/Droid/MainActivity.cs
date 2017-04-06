
using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using XamarinAllianceApp.Controllers;
using Auth0.AuthenticationApi;
using Auth0.Core;
using Auth0.ManagementApi;
using Cimpress.Auth0.Client;

namespace XamarinAllianceApp.Droid
{
    [Activity (Label = "Xamarin Alliance",
		Icon = "@drawable/icon",
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
		Theme = "@android:style/Theme.Holo.Light")]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, IAuthenticate
	{
        private MobileServiceUser user;
        AlertDialog.Builder builder;

        public AlertDialog.Builder getBuilder()
        {
             return builder;
        }

        public async Task<bool> Authenticate(String method)
        {
            var success = false;
            var message = string.Empty;
            try
            {
                // Sign in with Facebook login using a server-managed flow
                var client = new MobileServiceClient("https://xamarinalliancesecurebackend.azurewebsites.net");
                if (method == "Facebook")
                    user = await client.LoginAsync(this,MobileServiceAuthenticationProvider.Facebook);
                else if(method == "Twitter")
                    user = await client.LoginAsync(this, MobileServiceAuthenticationProvider.Twitter);
                if (user != null)
                {
                    message = string.Format("you are now signed-in as {0}.",user.UserId);
                    success = true;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            // Display the success or failure message.
            //builder.SetMessage(message);
            //builder.SetTitle("Sign-in result");
            //builder.Create().Show();

            SetBuilder("Sign-in result", message);
            ShowBuilder();

            return success;
        }

        public void SetBuilder(String title, String message)
        {
            if (builder != null)
            {
                builder.SetMessage(message);
                builder.SetTitle(title);
            }
        }

        public void ShowBuilder()
        {
            if(builder!=null)
                builder.Create().Show();
        }

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            App.Init((IAuthenticate)this);

            builder = new AlertDialog.Builder(this);

            // Initialize Xamarin Forms
            global::Xamarin.Forms.Forms.Init (this, bundle);

			// Load the main application
			LoadApplication (new App ());
        }
	}
}

