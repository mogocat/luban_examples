
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
   
public abstract partial class FlowNode :  ai.Node 
{
    public FlowNode(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("decorators"); Decorators = new System.Collections.Generic.List<ai.Decorator>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { ai.Decorator __v;  __v =  ai.Decorator.DeserializeDecorator(__e);  Decorators.Add(__v); }   }
        { var _json = _buf.GetProperty("services"); Services = new System.Collections.Generic.List<ai.Service>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { ai.Service __v;  __v =  ai.Service.DeserializeService(__e);  Services.Add(__v); }   }
    }

    public FlowNode(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services )  : base(id,node_name) 
    {
        this.Decorators = decorators;
        this.Services = services;
    }

    public static FlowNode DeserializeFlowNode(JsonElement _buf)
    {
    
        if (_buf.ValueKind == JsonValueKind.Null) { return null; }
        switch (_buf.GetProperty("__type__").GetString())
        {
            case "Sequence": return new ai.Sequence(_buf);
            case "Selector": return new ai.Selector(_buf);
            case "SimpleParallel": return new ai.SimpleParallel(_buf);
            case "UeWait": return new ai.UeWait(_buf);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_buf);
            case "MoveToTarget": return new ai.MoveToTarget(_buf);
            case "ChooseSkill": return new ai.ChooseSkill(_buf);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_buf);
            case "MoveToLocation": return new ai.MoveToLocation(_buf);
            case "DebugPrint": return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    
    }

     public readonly System.Collections.Generic.List<ai.Decorator> Decorators;
     public readonly System.Collections.Generic.List<ai.Service> Services;



    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            foreach(var _e in Decorators) { _e?.Resolve(_tables); }
            foreach(var _e in Services) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Decorators + ","
        + "Services:" + Services + ","
        + "}";
    }
    }
}

