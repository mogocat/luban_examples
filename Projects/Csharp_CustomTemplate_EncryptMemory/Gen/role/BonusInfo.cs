
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







namespace cfg.role
{
    [Serializable]
    public partial class BonusInfo : AConfig
    {
        public item.ECurrencyType  type { get; set; }

        [JsonProperty("coefficient")]
        private float _coefficient { get; set; }
        [JsonIgnore]
        public EncryptFloat coefficient { get; private set; } = new();


        public override void EndInit() 
        {
            coefficient = _coefficient;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}