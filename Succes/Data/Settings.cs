using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Succes.Data
{
    [DataContract]
    public class Settings
    {
        #region Game

        #endregion
        #region Player
        [DataMember]
        public readonly int STARTING_MONEY;
        [DataMember]
        public readonly int MAX_DOUBT;
        #endregion
        #region IO
        public static string GetSettingsPath(string mode) =>
            mode switch
            {
                "Easy" => "Easy.cfg",
                "Medium" => "Medium.cfg",
                "Hard" => "Hard.cfg",
                _ => "Medium.cfg"
            };
        public static Settings ReadSettings(string mode)
        {
            var deserialisedSettings = new Settings();
            var settingsPath = GetSettingsPath(mode);
            var sr = new StreamReader(settingsPath);
            var json = sr.ReadToEnd();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var serializer = new DataContractJsonSerializer(deserialisedSettings.GetType());
            deserialisedSettings = serializer.ReadObject(ms) as Settings;
            ms.Close();

            return deserialisedSettings;
        }
        public static void WriteSettings(string mode, Settings settings)
        {
            var settingsPath = GetSettingsPath(mode);
            var ms = new MemoryStream();
            var ser = new DataContractJsonSerializer(settings.GetType());
            ser.WriteObject(ms, settings);
            byte[] json = ms.ToArray();
            ms.Close();
            string jsonString = Encoding.UTF8.GetString(json, 0, json.Length);
            var sw = new StreamWriter(settingsPath);
            sw.WriteLine(jsonString);
        }
        #endregion
        public Settings()
        {
            
        }
    }
}
