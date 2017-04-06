using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAllianceApp.Controllers;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    public partial class CharacterListPage : ContentPage
    {
        private CharacterService service;
        bool authenticated = false;

        public CharacterListPage()
        {
            InitializeComponent();

            service = new CharacterService();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var method = await DisplayActionSheet("Sign-in method", "Cancel", null,"Facebook", "Twitter");
            if (method != "Cancel")
            {
                if (App.Authenticator != null)
                    authenticated = await App.Authenticator.Authenticate(method);

                // Set syncItems to true to synchronize the data on startup when offline is enabled.
                if (authenticated == true)
                    await RefreshItems(true, syncItems: false);
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Set syncItems to true in order to synchronize the data on startup when running in offline mode
            //await RefreshItems(true);
        }

        // http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/listview/#pulltorefresh
        public async void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            Exception error = null;
            if (authenticated)
            {
                try
                {
                    await RefreshItems(false);
                }
                catch (Exception ex)
                {
                    error = ex;
                }
                finally
                {
                    list.EndRefresh();
                }

                if (error != null)
                {
                    await DisplayAlert("Refresh Error", "Couldn't refresh data (" + error.Message + ")", "OK");
                }
            }
            else
            {
                list.EndRefresh();
                await DisplayAlert("Sign-in", "Please sign-in first", "OK");
            }
        }

        public async void OnSyncItems(object sender, EventArgs e)
        {
            await RefreshItems(true);
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Character;
            if (e.SelectedItem == null)
            {
                return;
            }
            Navigation.PushAsync(new CharacterDetailPage(item));
        }

        private async Task RefreshItems(bool showActivityIndicator, bool syncItems = false)
        {
            using (var scope = new ActivityIndicatorScope(syncIndicator, showActivityIndicator))
            {
                try
                {
                    characterList.ItemsSource = await service.GetCharactersAsync();
                }
                catch(Exception e)
                {
                    
                }
            }
        }

        private class ActivityIndicatorScope : IDisposable
        {
            private bool showIndicator;
            private ActivityIndicator indicator;
            private Task indicatorDelay;

            public ActivityIndicatorScope(ActivityIndicator indicator, bool showIndicator)
            {
                this.indicator = indicator;
                this.showIndicator = showIndicator;

                if (showIndicator)
                {
                    indicatorDelay = Task.Delay(2000);
                    SetIndicatorActivity(true);
                }
                else
                {
                    indicatorDelay = Task.FromResult(0);
                }
            }

            private void SetIndicatorActivity(bool isActive)
            {
                this.indicator.IsVisible = isActive;
                this.indicator.IsRunning = isActive;
            }

            public void Dispose()
            {
                if (showIndicator)
                {
                    indicatorDelay.ContinueWith(t => SetIndicatorActivity(false), TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }
    }
}

