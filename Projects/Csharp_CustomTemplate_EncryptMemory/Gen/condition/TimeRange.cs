
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







namespace cfg.condition
{
    [Serializable]
    public partial class TimeRange : AConfig
    {
        [JsonProperty]
        public common.DateTimeRange  date_time_range { get; set; }


        public override void EndInit() 
        {
            date_time_range.EndInit();
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            DateTimeRange?.TranslateText(translator);
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}