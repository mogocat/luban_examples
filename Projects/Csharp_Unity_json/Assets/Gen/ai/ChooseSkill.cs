
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

public sealed class ChooseSkill :  ai.Task 
{
    public ChooseSkill(JSONNode _json)  : base(_json) 
    {
        { if(!_json["target_actor_key"].IsString) { throw new SerializationException(); }  TargetActorKey = _json["target_actor_key"]; }
        { if(!_json["result_skill_id_key"].IsString) { throw new SerializationException(); }  ResultSkillIdKey = _json["result_skill_id_key"]; }
    }

    public ChooseSkill(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, string target_actor_key, string result_skill_id_key )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.TargetActorKey = target_actor_key;
        this.ResultSkillIdKey = result_skill_id_key;
    }

    public static ChooseSkill DeserializeChooseSkill(JSONNode _json)
    {
        return new ai.ChooseSkill(_json);
    }

    public string TargetActorKey { get; private set; }
    public string ResultSkillIdKey { get; private set; }

    public const int __ID__ = -918812268;
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
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "TargetActorKey:" + TargetActorKey + ","
        + "ResultSkillIdKey:" + ResultSkillIdKey + ","
        + "}";
    }
    }
}
