
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







namespace cfg.bonus
{
    [Serializable]
    public partial class ProbabilityBonusInfo : AConfig
    {
        [JsonProperty]
        public bonus.Bonus  bonus { get; set; }

        [JsonProperty("probability")]
        private float _probability { get; set; }
        [JsonIgnore]
        public EncryptFloat probability { get; private set; } = new();


        public override void EndInit() 
        {
            bonus.EndInit();
            probability = _probability;
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            Bonus?.TranslateText(translator);
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}