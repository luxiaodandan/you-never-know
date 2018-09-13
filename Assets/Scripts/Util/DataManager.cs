﻿using System;
using UnityEngine;

namespace Util
{
    public static class DataManager
    {
        public static void Save(string key, object obj)
        {
            try
            {
                string value = Serialize.SerializeObject(obj);
                PlayerPrefs.SetString(key, value);
            }
            catch (Exception ex)
            {
                throw new Exception("Data save exception: " + ex);
            }
        }

        public static T Get<T>(string key)
        {
            try
            {
                string value = PlayerPrefs.GetString(key);
                T obj = Serialize.DeserializeObject<T>(value);
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Data get exception: " + ex);
            }
        }
    }
}