
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.test
{

/// <summary>
/// 
/// </summary>
public sealed partial class DemoD2 :  test.DemoDynamic 
{
    public DemoD2(JSONNode _json)  : base(_json) 
    {
        { if(!_json["x2"].IsNumber) { throw new SerializationException(); }  X2 = _json["x2"]; }
    }

    public DemoD2(int x1, int x2 )  : base(x1) 
    {
        this.X2 = x2;
    }

    public static DemoD2 DeserializeDemoD2(JSONNode _json)
    {
        return new test.DemoD2(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int X2;

    public const int ID = -2138341747;
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
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "}";
    }
    }
}
