
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



namespace cfg.test
{

public sealed partial class DemoD2 :  test.DemoDynamic 
{
    public DemoD2(JsonElement _json)  : base(_json) 
    {
        X2 = _json.GetProperty("x2").GetInt32();
    }

    public DemoD2(int x1, int x2 )  : base(x1) 
    {
        this.X2 = x2;
    }

    public static DemoD2 DeserializeDemoD2(JsonElement _json)
    {
        return new test.DemoD2(_json);
    }

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

