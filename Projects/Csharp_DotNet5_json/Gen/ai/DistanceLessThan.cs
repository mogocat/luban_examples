
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
   
public sealed partial class DistanceLessThan :  ai.Decorator 
{
    public DistanceLessThan(JsonElement _buf)  : base(_buf) 
    {
        Actor1Key = _buf.GetProperty("actor1_key").GetString();
        Actor2Key = _buf.GetProperty("actor2_key").GetString();
        Distance = _buf.GetProperty("distance").GetSingle();
        ReverseResult = _buf.GetProperty("reverse_result").GetBoolean();
    }

    public DistanceLessThan(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, string actor1_key, string actor2_key, float distance, bool reverse_result )  : base(id,node_name,flow_abort_mode) 
    {
        this.Actor1Key = actor1_key;
        this.Actor2Key = actor2_key;
        this.Distance = distance;
        this.ReverseResult = reverse_result;
    }

    public static DistanceLessThan DeserializeDistanceLessThan(JsonElement _buf)
    {
        return new ai.DistanceLessThan(_buf);
    }

    public readonly string Actor1Key;
    public readonly string Actor2Key;
    public readonly float Distance;
    public readonly bool ReverseResult;

    public const int ID = -1207170283;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "Actor1Key:" + Actor1Key + ","
        + "Actor2Key:" + Actor2Key + ","
        + "Distance:" + Distance + ","
        + "ReverseResult:" + ReverseResult + ","
        + "}";
    }
    }
}

