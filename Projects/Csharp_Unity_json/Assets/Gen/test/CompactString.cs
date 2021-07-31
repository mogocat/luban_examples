
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
public sealed partial class CompactString :  Bright.Config.BeanBase 
{
    public CompactString(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["s2"].IsString) { throw new SerializationException(); }  S2 = _json["s2"]; }
        { if(!_json["s3"].IsString) { throw new SerializationException(); }  S3 = _json["s3"]; }
    }

    public CompactString(int id, string s2, string s3 ) 
    {
        this.Id = id;
        this.S2 = s2;
        this.S3 = s3;
    }

    public static CompactString DeserializeCompactString(JSONNode _json)
    {
        return new test.CompactString(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly string S2;
    /// <summary>
    /// 
    /// </summary>
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
