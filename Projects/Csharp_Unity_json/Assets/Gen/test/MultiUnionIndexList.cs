
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

public sealed class MultiUnionIndexList :  Bright.Config.BeanBase 
{
    public MultiUnionIndexList(JSONNode _json) 
    {
        { if(!_json["id1"].IsNumber) { throw new SerializationException(); }  Id1 = _json["id1"]; }
        { if(!_json["id2"].IsNumber) { throw new SerializationException(); }  Id2 = _json["id2"]; }
        { if(!_json["id3"].IsString) { throw new SerializationException(); }  Id3 = _json["id3"]; }
        { if(!_json["num"].IsNumber) { throw new SerializationException(); }  Num = _json["num"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
    }

    public MultiUnionIndexList(int id1, long id2, string id3, int num, string desc ) 
    {
        this.Id1 = id1;
        this.Id2 = id2;
        this.Id3 = id3;
        this.Num = num;
        this.Desc = desc;
    }

    public static MultiUnionIndexList DeserializeMultiUnionIndexList(JSONNode _json)
    {
        return new test.MultiUnionIndexList(_json);
    }

    public int Id1 { get; private set; }
    public long Id2 { get; private set; }
    public string Id3 { get; private set; }
    public int Num { get; private set; }
    public string Desc { get; private set; }

    public const int __ID__ = 1966847134;
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
        + "Id1:" + Id1 + ","
        + "Id2:" + Id2 + ","
        + "Id3:" + Id3 + ","
        + "Num:" + Num + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    }
}
