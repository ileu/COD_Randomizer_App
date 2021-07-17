using COD_Randomizer_App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace COD_Randomizer_App.Services
{
    public static class LocalDataService
    {
        private static MotherLoadout motherLoadout;

        public static MotherLoadout MotherLoadout => motherLoadout ??= LoadMotherLoadout();

        public static MotherLoadout LoadMotherLoadout()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(LocalDataService)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("COD_Randomizer_App.Resources.TestJson.json");

            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            var dataObject = JsonConvert.DeserializeObject<MotherLoadout>(json);
            return motherLoadout = dataObject;
        }
    }
}
