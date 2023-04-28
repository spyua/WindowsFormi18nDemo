using System.Collections.Generic;
using System.Collections;
using System;
using System.Resources;
using System.IO;

namespace LanguagePackage
{
    /// <summary>
    /// 多語使用翻譯機
    /// </summary>
    public static class LanguageInterpret
    {

        /// <summary>
        /// 多國語言種類，resx檔名請與enum名稱一樣 (公司只分英中 Zh_Tw與En_Us)
        /// </summary>
        public enum LanguageClassify
        {
            /// <summary>
            /// 中文
            /// </summary>
            Zh_Tw,
            /// <summary>
            /// 英文
            /// </summary>
            En_Us
        }

        private static LanguageClassify _nowLanguage;

        /// <summary>
        /// 目前語言(需優先設置資料)
        /// </summary>
        public static LanguageClassify NowLanguage
        {
            get { return _nowLanguage; }
            set
            {
                _nowLanguage = value;
                LoadLanguageDic(_nowLanguage.ToString());
                OnLanguateChange?.Invoke();
            }
        }

        /// <summary>
        /// 多國語路徑檔(需優先設置資料)
        /// </summary>
        public static string ResourcePath;

        /// <summary>
        /// 多國語系語言改變註冊
        /// </summary>
        public static Action OnLanguateChange;

        /// <summary>
        /// 頁面翻譯文字
        /// </summary>
        public static Dictionary<string, string> ViewElmentLanguageDic { get; private set; }

        /// <summary>
        /// 訊息翻譯文字
        /// </summary>
        public static Dictionary<string, string> MessageLanguageDic { get; private set; }

        /// <summary>
        /// 翻譯訊息
        /// </summary>
        /// <param name="message">要翻譯文字</param>
        /// <returns>翻譯結果文字 or 原文字(找不到時)</returns>
        public static string InterpretMessage(string message)
        {
            if (!MessageLanguageDic.ContainsKey(message))
                return message;

            return MessageLanguageDic[message];
        }

        /// <summary>
        /// 翻譯文字
        /// </summary>
        /// <param name="text">要翻譯文字</param>
        /// <returns>翻譯結果文字 or 原文字(找不到時)</returns>
        public static string InterpretViewText(string text)
        {
            var getValue = text;

            foreach (var key in ViewElmentLanguageDic.Keys)
            {
                if (!text.Contains(key))
                    continue;

                getValue = ViewElmentLanguageDic[key];
                break;
            }

            return getValue;
        }

        /// <summary>
        /// Load Resx資料
        /// </summary>
        /// <param name="language"></param>
        public static void LoadLanguageDic(string language)
        {
            ViewElmentLanguageDic = new Dictionary<string, string>();
            MessageLanguageDic = new Dictionary<string, string>();

            var resourcePath = ResourcePath + "\\" + language + ".resx";

            if (!File.Exists(resourcePath))
            {
                //throw new FileNotFoundException(resourcePath);
                return;
            }


            using (var resxReader = new ResXResourceReader(resourcePath))
            {
                foreach (DictionaryEntry entry in resxReader)
                {
                    var key = (string)entry.Key;
                    var value = (string)entry.Value;

                    // 表句子
                    if (key.Contains("@"))
                    {
                        MessageLanguageDic.Add(key, value);
                        continue;
                    }
                    ViewElmentLanguageDic.Add(key, value);
                }
            }
        }

    }
}
