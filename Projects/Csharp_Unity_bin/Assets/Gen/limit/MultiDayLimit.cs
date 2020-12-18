
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
   
public sealed partial class MultiDayLimit :  limit.LimitBase 
{
    public MultiDayLimit(ByteBuf _buf)  : base(_buf) 
    {
        Day = _buf.ReadInt();
        Num = _buf.ReadInt();
    }

    public MultiDayLimit(int day, int num )  : base() 
    {
        this.Day = day;
        this.Num = num;
    }

    public static MultiDayLimit DeserializeMultiDayLimit(ByteBuf _buf)
    {
    
        return new limit.MultiDayLimit(_buf);
    
    }

     public readonly int Day;
     public readonly int Num;


    public const int ID = -1753629499;
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
        + "Day:" + Day + ","
        + "Num:" + Num + ","
        + "}";
    }
    }

}

