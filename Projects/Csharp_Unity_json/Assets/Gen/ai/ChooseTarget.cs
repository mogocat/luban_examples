
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.ai
{

public sealed class ChooseTarget :  ai.Service 
{
    public ChooseTarget(JSONNode _json)  : base(_json) 
    {
        { if(!_json["result_target_key"].IsString) { throw new SerializationException(); }  ResultTargetKey = _json["result_target_key"]; }
    }

    public ChooseTarget(int id, string node_name, string result_target_key )  : base(id,node_name) 
    {
        this.ResultTargetKey = result_target_key;
    }

    public static ChooseTarget DeserializeChooseTarget(JSONNode _json)
    {
        return new ai.ChooseTarget(_json);
    }

    public string ResultTargetKey { get; private set; }

    public const int __ID__ = 1601247918;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "ResultTargetKey:" + ResultTargetKey + ","
        + "}";
    }
    }
}
