
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Nireus.Base;
using Nireus.Model;
using Newtonsoft.Json;







namespace cfg.l10n
{
    [Serializable]
    public partial class L10NDemo : AConfig
    {

        public string  text { get; set; }

        public string Text_l10n_key { get; }

        public override void EndInit() 
        {
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            Text = translator(Text_l10n_key, Text);
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}