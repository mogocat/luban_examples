
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.limit
{

public sealed partial class DailyLimit :  limit.DailyLimitBase 
{
    public DailyLimit(ByteBuf _buf)  : base(_buf) 
    {
        Num = _buf.ReadInt();
    }

    public DailyLimit(int num )  : base() 
    {
        this.Num = num;
    }

    public static DailyLimit DeserializeDailyLimit(ByteBuf _buf)
    {
        return new limit.DailyLimit(_buf);
    }

    public readonly int Num;

    public const int ID = 303235413;
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
