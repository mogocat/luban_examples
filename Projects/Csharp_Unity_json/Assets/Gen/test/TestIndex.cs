
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

public sealed class TestIndex :  Bright.Config.BeanBase 
{
    public TestIndex(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { var _json1 = _json["eles"]; if(!_json1.IsArray) { throw new SerializationException(); } Eles = new System.Collections.Generic.List<test.DemoType1>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.DemoType1 __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.DemoType1.DeserializeDemoType1(__e); }  Eles.Add(__v); }   }
    }

    public TestIndex(int id, System.Collections.Generic.List<test.DemoType1> eles ) 
    {
        this.Id = id;
        this.Eles = eles;
    }

    public static TestIndex DeserializeTestIndex(JSONNode _json)
    {
        return new test.TestIndex(_json);
    }

    public int Id { get; private set; }
    public System.Collections.Generic.List<test.DemoType1> Eles { get; private set; }

    public const int ID = 1941154020;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Eles) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Eles) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Eles:" + Bright.Common.StringUtil.CollectionToString(Eles) + ","
        + "}";
    }
    }
}
