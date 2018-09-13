﻿using System;
using System.Text;
using System.Security.Cryptography;

namespace Util
{
    public static class Encrypt
    {
        /// <summary>
        /// Rijndaels the encrypt.
        /// </summary>
        /// <returns>The encrypt.</returns>
        /// <param name="str">String.</param>
        /// <param name="key">Key.</param>
        public static string RijndaelEncrypt(string str, string key)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// Rijndaels the decrypt.
        /// </summary>
        /// <returns>The decrypt.</returns>
        /// <param name="str">String.</param>
        /// <param name="key">Key.</param>
        public static string RijndaelDecrypt(string str, string key)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(str);
            RijndaelManaged rDel = new RijndaelManaged
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }
    }
}