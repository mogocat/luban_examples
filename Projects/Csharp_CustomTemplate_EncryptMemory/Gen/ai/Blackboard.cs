
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
    public partial class Blackboard : AConfig
    {
        public string  name { get; set; }

        public string  desc { get; set; }

        public string  parent_name { get; set; }

        public System.Collections.Generic.List<ai.BlackboardKey>  keys { get; set; }


        public override void EndInit() 
        {
            foreach(var _e in keys) { _e.EndInit(); }
        }

        public override void TranslateText(Func<string, string, string> translator)
        {
            foreach(var _e in Keys) { _e?.TranslateText(translator); }
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}