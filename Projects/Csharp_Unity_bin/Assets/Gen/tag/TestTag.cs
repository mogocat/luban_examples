
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.tag
{
   
public sealed partial class TestTag :  Bright.Config.BeanBase 
{
    public TestTag(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Value = _buf.ReadString();
    }

    public TestTag(int id, string value ) 
    {
        this.Id = id;
        this.Value = value;
    }

    public static TestTag DeserializeTestTag(ByteBuf _buf)
    {
    
        return new tag.TestTag(_buf);
    
    }

    public readonly int Id;
    public readonly string Value;


    public const int ID = 1742933812;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Value:" + Value + ","
        + "}";
    }
    }

}

