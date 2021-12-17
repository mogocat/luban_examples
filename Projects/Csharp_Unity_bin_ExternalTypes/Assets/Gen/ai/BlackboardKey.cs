
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed class BlackboardKey :  Bright.Config.BeanBase 
{
    public BlackboardKey(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        IsStatic = _buf.ReadBool();
        Type = (ai.EKeyType)_buf.ReadInt();
        TypeClassName = _buf.ReadString();
    }

    public static BlackboardKey DeserializeBlackboardKey(ByteBuf _buf)
    {
        return new ai.BlackboardKey(_buf);
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public bool IsStatic { get; private set; }
    public ai.EKeyType Type { get; private set; }
    public string TypeClassName { get; private set; }

    public const int __ID__ = -511559886;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "Type:" + Type + ","
        + "TypeClassName:" + TypeClassName + ","
        + "}";
    }
    }

}