
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

public abstract partial class DailyLimitBase :  limit.LimitBase 
{
    public DailyLimitBase(ByteBuf _buf)  : base(_buf) 
    {
    }

    public static DailyLimitBase DeserializeDailyLimitBase(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case limit.DailyLimit.ID: return new limit.DailyLimit(_buf);
            default: throw new SerializationException();
        }
    }



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
        + "}";
    }
    }

}