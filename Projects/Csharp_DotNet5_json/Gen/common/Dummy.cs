
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



namespace cfg.common
{
   
public sealed partial class Dummy :  Bright.Config.BeanBase 
{
    public Dummy(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        { var _j = _buf.GetProperty("limit"); if (_j.ValueKind != JsonValueKind.Null) { Limit =  limit.LimitBase.DeserializeLimitBase(_j); } else { Limit = null; } }
    }

    public Dummy(int id, limit.LimitBase limit ) 
    {
        this.Id = id;
        this.Limit = limit;
    }

    public static Dummy DeserializeDummy(JsonElement _buf)
    {
    
        return new common.Dummy(_buf);
    
    }

     public readonly int Id;
     public readonly limit.LimitBase Limit;


    public const int ID = -985084219;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

            Limit?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Limit:" + Limit + ","
        + "}";
    }
    }
}
