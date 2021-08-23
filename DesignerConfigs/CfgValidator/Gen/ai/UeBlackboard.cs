
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{

public sealed partial class UeBlackboard :  ai.Decorator 
{
    public UeBlackboard(JsonElement _json)  : base(_json) 
    {
        NotifyObserver = (ai.ENotifyObserverMode)_json.GetProperty("notify_observer").GetInt32();
        BlackboardKey = _json.GetProperty("blackboard_key").GetString();
        KeyQuery =  ai.KeyQueryOperator.DeserializeKeyQueryOperator(_json.GetProperty("key_query"));
    }

    public UeBlackboard(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, ai.ENotifyObserverMode notify_observer, string blackboard_key, ai.KeyQueryOperator key_query )  : base(id,node_name,flow_abort_mode) 
    {
        this.NotifyObserver = notify_observer;
        this.BlackboardKey = blackboard_key;
        this.KeyQuery = key_query;
    }

    public static UeBlackboard DeserializeUeBlackboard(JsonElement _json)
    {
        return new ai.UeBlackboard(_json);
    }

    public readonly ai.ENotifyObserverMode NotifyObserver;
    public readonly string BlackboardKey;
    public readonly ai.KeyQueryOperator KeyQuery;

    public const int ID = -315297507;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        KeyQuery?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "NotifyObserver:" + NotifyObserver + ","
        + "BlackboardKey:" + BlackboardKey + ","
        + "KeyQuery:" + KeyQuery + ","
        + "}";
    }
    }
}

