
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
   
public sealed partial class WeeklyLimit :  limit.LimitBase 
{
    public WeeklyLimit(JsonElement _buf)  : base(_buf) 
    {
        Num = _buf.GetProperty("num").GetInt32();
    }

    public WeeklyLimit(int num )  : base() 
    {
        this.Num = num;
    }

    public static WeeklyLimit DeserializeWeeklyLimit(JsonElement _buf)
    {
        return new limit.WeeklyLimit(_buf);
    }

    public readonly int Num;

    public const int ID = -252187161;
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
        + "Num:" + Num + ","
        + "}";
    }
    }
}

