﻿using System;
using System.IO;

namespace Util
{
    public static class IOHelper
    {
        /// <summary>
        /// Is the file exists.
        /// </summary>
        /// <returns><c>true</c>, if the file exists, <c>false</c> otherwise.</returns>
        /// <param name="fileName">File name.</param>
        public static bool IsFileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        /// <summary>
        /// Is the directory exist.
        /// </summary>
        /// <returns><c>true</c>, if the directory exist, <c>false</c> otherwise.</returns>
        /// <param name="directorName">Director name.</param>
        public static bool IsDirectoryExist(string directorName)
        {
            return Directory.Exists(directorName);
        }

        /// <summary>
        /// Create the file.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="content">Content.</param>
        public static void CreateFile(string fileName, string content)
        {
            StreamWriter streamWriter = File.CreateText(fileName);
            streamWriter.Write(content);
            streamWriter.Close();
        }

        /// <summary>
        /// Create the directory.
        /// </summary>
        /// <param name="directoryName">Directory name.</param>
        public static void CreateDirectory(string directoryName)
        {
            if (IsDirectoryExist(directoryName))
            {
                return;
            }
            Directory.CreateDirectory(directoryName);
        }

        /// <summary>
        /// Set the data.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="obj">Object.</param>
        public static void SetData(string fileName, object obj)
        {
            string toSave = Serialize.SerializeObject(obj);

            toSave = Encrypt.RijndaelEncrypt(toSave, Config.Config.SecretKey.PadRight(32, 'x'));
            CreateFile(fileName, toSave);
        }

        /// <summary>
        /// Get the data.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="fileName">File name.</param>
        /// <param name="type">Type.</param>
        public static T GetData<T>(string fileName)
        {
            StreamReader streamReader = File.OpenText(fileName);
            string data = streamReader.ReadToEnd();

            data = Encrypt.RijndaelDecrypt(data, Config.Config.SecretKey.PadRight(32, 'x'));
            streamReader.Close();
            return Serialize.DeserializeObject<T>(data);
        }
    }
}