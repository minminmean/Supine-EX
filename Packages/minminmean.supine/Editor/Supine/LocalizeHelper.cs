using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Supine
{
    public static class LocalizeHelper
    {
        private static string _localizeGuid = "c2457975623f2cc489bb34d9bcca983e";

        public enum Language
            {
                Japanese = 0,
                English
            };

        private static string[] _localizeJsons =
            {
                "ja.json",
                "en.json"
            };

        public static LocalizeDictionary GetLocalizedTexts(int languageOrder)
        {
            string localizePath = AssetDatabase.GUIDToAssetPath(_localizeGuid);
            FileStream fs = new FileStream(localizePath + "/" + _localizeJsons[languageOrder], FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader reader = new StreamReader(fs);
            string jsonContent = reader.ReadToEnd();
            reader.Close();

            LocalizeDictionary dict = JsonUtility.FromJson<LocalizeDictionary>(jsonContent);
            return dict;
        }


    }
}