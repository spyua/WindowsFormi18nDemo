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
            zh_Tw, en_Us, ar_EG, az_AZ, bg_BG, bn_BD, by_BY, ca_ES, cs_CZ, da_DK,
            de_DE, el_GR, en_GB, en_US, es_ES, eu_ES, et_EE, fa_IR, fi_FI, fr_BE,
            fr_CA, fr_FR, ga_IE, gl_ES, he_IL, hi_IN, hr_HR, hu_HU, hy_AM, id_ID,
            it_IT, is_IS, ja_JP, ka_GE, kmr_IQ, kn_IN, kk_KZ, km_KH, ko_KR, lt_LT,
            lv_LV, mk_MK, ml_IN, mn_MN, ms_MY, nb_NO, ne_NP, nl_BE, nl_NL, pl_PL,
            pt_BR, pt_PT, ro_RO, ru_RU, si_LK, sk_SK, sr_RS, sl_SI, sv_SE, ta_IN,
            th_TH, tr_TR, tk_TK, ur_PK, uk_UA, vi_VN, zh_CN, zh_HK, my_MM
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
