
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
   
public sealed partial class H1 :  Bright.Config.BeanBase 
{
    public H1(ByteBuf _buf) 
    {
        Y2 = test.H2.DeserializeH2(_buf);
        Y3 = _buf.ReadInt();
    }

    public H1(test.H2 y2, int y3 ) 
    {
        this.Y2 = y2;
        this.Y3 = y3;
    }

    public static H1 DeserializeH1(ByteBuf _buf)
    {
        return new test.H1(_buf);
    }

    public readonly test.H2 Y2;
    public readonly int Y3;

    public const int ID = -1422503995;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Y2?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Y2:" + Y2 + ","
        + "Y3:" + Y3 + ","
        + "}";
    }
    }

}

