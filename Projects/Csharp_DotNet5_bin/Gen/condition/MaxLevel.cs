
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{

public sealed class MaxLevel :  condition.BoolRoleCondition 
{
    public MaxLevel(ByteBuf _buf)  : base(_buf) 
    {
        Level = _buf.ReadInt();
    }

    public static MaxLevel DeserializeMaxLevel(ByteBuf _buf)
    {
        return new condition.MaxLevel(_buf);
    }

    public int Level { get; private set; }

    public const int __ID__ = 700922899;
    public override int GetTypeId() => __ID__;

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
        + "Level:" + Level + ","
        + "}";
    }
    }

}
