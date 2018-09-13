﻿using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Config
{
    public static class Config
    {
        /// <summary>
        /// The save game data path.
        /// </summary>
        public static string SAVE_DATA_PATH = Application.persistentDataPath + "/Save";

        // game data save file name
        /// <summary>
        /// The name of the save game data file.
        /// </summary>
        public static string SAVE_DATA_FILE_NAME = SAVE_DATA_PATH + "/GameData.sav";

        /// <summary>
        /// Get the secret key of game data encrypt.
        /// </summary>
        /// <value>The secret key.</value>
        public static string SecretKey
        {
            get
            {
                string secretKey = "";
                try
                {
                    StreamReader file = File.OpenText(Application.dataPath + "/Config/game.config.json");
                    JsonTextReader jsonTextReader = new JsonTextReader(file);
                    JObject jObject = (JObject)JToken.ReadFrom(jsonTextReader);
                    secretKey = (string)jObject["secret-key"];
                }
                catch
                {
                    throw new FileLoadException("json file read error");
                }
                return secretKey;
            }
        }
    }
}