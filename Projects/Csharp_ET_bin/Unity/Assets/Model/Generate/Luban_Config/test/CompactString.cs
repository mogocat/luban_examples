
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

public sealed partial class CompactString :  Bright.Config.BeanBase 
{
    public CompactString(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        S2 = _buf.ReadString();
        S3 = _buf.ReadString();
    }

    public CompactString(int id, string s2, string s3 ) 
    {
        this.Id = id;
        this.S2 = s2;
        this.S3 = s3;
    }

    public static CompactString DeserializeCompactString(ByteBuf _buf)
    {
        return new test.CompactString(_buf);
    }

    public readonly int Id;
    public readonly string S2;
    public readonly string S3;

    public const int ID = 1968089240;
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
        + "S2:" + S2 + ","
        + "S3:" + S3 + ","
        + "}";
    }
    }

}

