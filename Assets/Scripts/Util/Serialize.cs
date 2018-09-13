﻿using System;
using Newtonsoft.Json;
namespace Util
{
    public static class Serialize
    {
        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="obj">Object.</param>
        public static string SerializeObject(object obj)
        {
            string serializeString = string.Empty;
            //JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //};

            serializeString = JsonConvert.SerializeObject(obj);
            return serializeString;
        }

        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="str">String.</param>
        public static T DeserializeObject<T>(string str)
        {
            T deserializeObject;
            deserializeObject = JsonConvert.DeserializeObject<T>(str);
            return deserializeObject;
        }
    }
}