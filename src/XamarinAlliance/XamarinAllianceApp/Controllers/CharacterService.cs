using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using XamarinAllianceApp.Helpers;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Controllers
{
    public class CharacterService
    {
        /// <summary>
        /// Get the list of characters
        /// </summary>
        /// <returns>ObservableCollection of Character objects</returns>
        public async Task<ObservableCollection<Character>> GetCharactersAsync()
        {
            string mobileServiceClientUrl = "http://xamarinalliancebackend.azurewebsites.net";
            MobileServiceClient Client = new MobileServiceClient(mobileServiceClientUrl);
            IMobileServiceTable<Character> CharacterTable = Client.GetTable<Character>();
            var characters = await CharacterTable.ToListAsync();
            return new ObservableCollection<Character>(characters);
        }

        /// <summary>
        /// Get the list of characters from an embedded JSON file, including their child entities.
        /// </summary>
        /// <returns>Array of Character objects</returns>
        private async Task<Character[]> ReadCharactersFromFile()
        {
            var assembly = typeof(CharacterService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(Constants.CharactersFilename);
            string text;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = await reader.ReadToEndAsync();
            }

            var characters = JsonConvert.DeserializeObject<Character[]>(text);
            return characters;
        }
    }
}
