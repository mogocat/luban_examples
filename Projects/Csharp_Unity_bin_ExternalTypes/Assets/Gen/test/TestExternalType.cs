
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed class TestExternalType :  Bright.Config.BeanBase 
{
    public TestExternalType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        AudioType = (UnityEngine.AudioType)_buf.ReadInt();
        Color = ExternalTypeUtil.NewFromCfgColor(test.Color.DeserializeColor(_buf));
    }

    public static TestExternalType DeserializeTestExternalType(ByteBuf _buf)
    {
        return new test.TestExternalType(_buf);
    }

    public int Id { get; private set; }
    public UnityEngine.AudioType AudioType { get; private set; }
    public UnityEngine.Color Color { get; private set; }

    public const int __ID__ = -990826157;
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
        + "Id:" + Id + ","
        + "AudioType:" + AudioType + ","
        + "Color:" + Color + ","
        + "}";
    }
    }

}