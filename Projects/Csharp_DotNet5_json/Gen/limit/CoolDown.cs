
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



namespace cfg.limit
{
   
public sealed partial class CoolDown :  limit.LimitBase 
{
    public CoolDown(JsonElement _buf)  : base(_buf) 
    {
        Duration = _buf.GetProperty("duration").GetInt32();
    }

    public CoolDown(int duration )  : base() 
    {
        this.Duration = duration;
    }

    public static CoolDown DeserializeCoolDown(JsonElement _buf)
    {
    
        return new limit.CoolDown(_buf);
    
    }

     public readonly int Duration;


    public const int ID = -1366194050;
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
        + "Duration:" + Duration + ","
        + "}";
    }
    }
}

