
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

public sealed class IntKeyData :  ai.KeyData 
{
    public IntKeyData(JSONNode _json)  : base(_json) 
    {
        { if(!_json["value"].IsNumber) { throw new SerializationException(); }  Value = _json["value"]; }
    }

    public IntKeyData(int value )  : base() 
    {
        this.Value = value;
    }

    public static IntKeyData DeserializeIntKeyData(JSONNode _json)
    {
        return new ai.IntKeyData(_json);
    }

    public int Value { get; private set; }

    public const int __ID__ = -342751904;
    public override int GetTypeId() => __ID__;

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
