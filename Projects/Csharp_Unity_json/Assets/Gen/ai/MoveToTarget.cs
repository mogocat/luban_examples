
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

public sealed class MoveToTarget :  ai.Task 
{
    public MoveToTarget(JSONNode _json)  : base(_json) 
    {
        { if(!_json["target_actor_key"].IsString) { throw new SerializationException(); }  TargetActorKey = _json["target_actor_key"]; }
        { if(!_json["acceptable_radius"].IsNumber) { throw new SerializationException(); }  AcceptableRadius = _json["acceptable_radius"]; }
    }

    public MoveToTarget(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, string target_actor_key, float acceptable_radius )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.TargetActorKey = target_actor_key;
        this.AcceptableRadius = acceptable_radius;
    }

    public static MoveToTarget DeserializeMoveToTarget(JSONNode _json)
    {
        return new ai.MoveToTarget(_json);
    }

    public string TargetActorKey { get; private set; }
    public float AcceptableRadius { get; private set; }

    public const int ID = 514987779;
    public override int GetTypeId() => ID;

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
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    }
}
