
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







namespace cfg.ai
{
    [Serializable]
    public partial class FloatKeyData : AConfig
    {
        [JsonProperty("value")]
        private float _value { get; set; }
        [JsonIgnore]
        public EncryptFloat value { get; private set; } = new();


        public override void EndInit() 
        {
            value = _value;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}