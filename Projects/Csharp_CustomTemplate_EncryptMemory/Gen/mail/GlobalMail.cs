
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







namespace cfg.mail
{
    [Serializable]
    public partial class GlobalMail : AConfig
    {

        public string  title { get; set; }

        public string  sender { get; set; }

        public string  content { get; set; }

        public System.Collections.Generic.List<int>  award { get; set; }

        public bool  all_server { get; set; }

        public System.Collections.Generic.List<int>  server_list { get; set; }

        public string  platform { get; set; }

        public string  channel { get; set; }

        [JsonProperty]
        public condition.MinMaxLevel  min_max_level { get; set; }

        [JsonProperty]
        public condition.TimeRange  register_time { get; set; }

        [JsonProperty]
        public condition.TimeRange  mail_time { get; set; }


        public override void EndInit() 
        {
            min_max_level.EndInit();
            register_time.EndInit();
            mail_time.EndInit();
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            MinMaxLevel?.TranslateText(translator);
            RegisterTime?.TranslateText(translator);
            MailTime?.TranslateText(translator);
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}