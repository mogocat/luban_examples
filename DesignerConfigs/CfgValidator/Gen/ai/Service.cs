
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

public abstract partial class Service :  ai.Node 
{
    public Service(JsonElement _json)  : base(_json) 
    {
    }

    public Service(int id, string node_name )  : base(id,node_name) 
    {
    }

    public static Service DeserializeService(JsonElement _json)
    {
        switch (_json.GetProperty("__type__").GetString())
        {
            case "UeSetDefaultFocus": return new ai.UeSetDefaultFocus(_json);
            case "ExecuteTimeStatistic": return new ai.ExecuteTimeStatistic(_json);
            case "ChooseTarget": return new ai.ChooseTarget(_json);
            case "KeepFaceTarget": return new ai.KeepFaceTarget(_json);
            case "GetOwnerPlayer": return new ai.GetOwnerPlayer(_json);
            case "UpdateDailyBehaviorProps": return new ai.UpdateDailyBehaviorProps(_json);
            default: throw new SerializationException();
        }
    }



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
        + "}";
    }
    }
}

