
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

/// <summary>
/// 这是个测试excel结构
/// </summary>
public sealed class TestExcelBean1 :  Bright.Config.BeanBase 
{
    public TestExcelBean1(ByteBuf _buf) 
    {
        X1 = _buf.ReadInt();
        X2 = _buf.ReadString();
        X3 = _buf.ReadInt();
        X4 = _buf.ReadFloat();
    }

    public static TestExcelBean1 DeserializeTestExcelBean1(ByteBuf _buf)
    {
        return new test.TestExcelBean1(_buf);
    }

    /// <summary>
    /// 最高品质
    /// </summary>
    public int X1 { get; private set; }
    /// <summary>
    /// 黑色的
    /// </summary>
    public string X2 { get; private set; }
    /// <summary>
    /// 蓝色的
    /// </summary>
    public int X3 { get; private set; }
    /// <summary>
    /// 最差品质
    /// </summary>
    public float X4 { get; private set; }

    public const int ID = -1738345160;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "}";
    }
    }

}
