
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



namespace cfg.ai
{

public sealed class StringKeyData :  ai.KeyData 
{
    public StringKeyData(JSONNode _json)  : base(_json) 
    {
        { if(!_json["value"].IsString) { throw new SerializationException(); }  Value = _json["value"]; }
    }

    public StringKeyData(string value )  : base() 
    {
        this.Value = value;
    }

    public static StringKeyData DeserializeStringKeyData(JSONNode _json)
    {
        return new ai.StringKeyData(_json);
    }

    public string Value { get; private set; }

    public const int ID = -307888654;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Value:" + Value + ","
        + "}";
    }
    }
}
