using System.Collections.Generic;
using System.Windows.Forms;

namespace LanguagePackage
{
    /// <summary>
    /// Form View使用多語協助管理Control
    /// </summary>
    public class LanguageInterpretViewManager
    {
        /// <summary>
        /// 需多語顯示頁面
        /// </summary>
        public List<Control> MultiLanguageDisplayControls;

        /// <summary>
        /// 原頁面Text
        /// </summary>
        public Dictionary<Control, string> LanguageDisplayInitialStatusKey;

        /// <summary>
        /// 頁面目前Text
        /// </summary>
        public Dictionary<Control, string> LanguageDisplayValue;

        /// <summary>
        /// 顯示Control Text
        /// </summary>
        public void SetAllViewText()
        {
            foreach (var viewControl in MultiLanguageDisplayControls)
            {
                if (!LanguageDisplayInitialStatusKey.ContainsKey(viewControl))
                    continue;

                var textKey = LanguageDisplayInitialStatusKey[viewControl];
                var textValue = LanguageInterpret.InterpretViewText(textKey);

                if (LanguageDisplayValue.ContainsKey(viewControl))
                {
                    var replaceText = viewControl.Text.Replace(LanguageDisplayValue[viewControl], LanguageInterpret.InterpretViewText(textKey));
                    viewControl.Text = replaceText;
                    LanguageDisplayValue[viewControl] = textValue;
                }
                else
                {
                    LanguageDisplayValue.Add(viewControl, textValue);
                    // 特殊字元: 要統一整理
                    var replaceText = viewControl.Text.Replace(viewControl.Text.Replace(":", string.Empty), LanguageInterpret.InterpretViewText(textKey));
                    viewControl.Text = replaceText;
                }
            }
        }

        /// <summary>
        /// 設置欲根據多國設定而改變顯示的sControl
        /// </summary>
        /// <param name="controlViews"></param>
        public void SetLanguageControl(List<Control> controlViews)
        {
            LanguageDisplayInitialStatusKey = new Dictionary<Control, string>();
            MultiLanguageDisplayControls = controlViews;
            foreach (var control in MultiLanguageDisplayControls)
                LanguageDisplayInitialStatusKey.Add(control, control.Text);
        }

        /// <summary>
        /// 建構子
        /// </summary>
        public LanguageInterpretViewManager()
        {
            LanguageDisplayValue = new Dictionary<Control, string>();
        }
    }
}
