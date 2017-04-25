using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterDetailPage : ContentPage
    {
        Uri databankUri;

        public CharacterDetailPage(Character character)
        {
            InitializeComponent();
            this.Title = character.Name;
            characterImage.Source = ImageSource.FromUri(new Uri(character.ImageUrl));
            nameLabel.Text = character.Name;
            descriptionLabel.Text = character.Biography;
            genderLabel.Text = "Gender: " + character.Gender;
            heightLabel.Text = "Height: " + character.Height;
            databankLink.Text = character.DatabankUrl;
            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => OnLabelClicked();
            databankLink.GestureRecognizers.Add(tgr);
            databankUri = new Uri(character.DatabankUrl);
        }

        void OnLabelClicked()
        {
            Device.OpenUri(databankUri);
        }
    }
}
