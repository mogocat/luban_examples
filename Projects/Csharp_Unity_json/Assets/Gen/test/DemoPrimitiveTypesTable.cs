
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

public sealed class DemoPrimitiveTypesTable :  Bright.Config.BeanBase 
{
    public DemoPrimitiveTypesTable(JSONNode _json) 
    {
        { if(!_json["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _json["x1"]; }
        { if(!_json["x2"].IsNumber) { throw new SerializationException(); }  X2 = _json["x2"]; }
        { if(!_json["x3"].IsNumber) { throw new SerializationException(); }  X3 = _json["x3"]; }
        { if(!_json["x4"].IsNumber) { throw new SerializationException(); }  X4 = _json["x4"]; }
        { if(!_json["x5"].IsNumber) { throw new SerializationException(); }  X5 = _json["x5"]; }
        { if(!_json["x6"].IsNumber) { throw new SerializationException(); }  X6 = _json["x6"]; }
        { if(!_json["x7"].IsNumber) { throw new SerializationException(); }  X7 = _json["x7"]; }
        { if(!_json["s1"].IsString) { throw new SerializationException(); }  S1 = _json["s1"]; }
        { if(!_json["s2"]["key"].IsString) { throw new SerializationException(); }  S2_l10n_key = _json["s2"]["key"]; if(!_json["s2"]["text"].IsString) { throw new SerializationException(); }  S2 = _json["s2"]["text"]; }
        { var _json2 = _json["v2"]; if(!_json2.IsObject) { throw new SerializationException(); }  float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } V2 = new System.Numerics.Vector2(__x, __y); }
        { var _json2 = _json["v3"]; if(!_json2.IsObject) { throw new SerializationException(); } float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } float __z; { if(!_json2["z"].IsNumber) { throw new SerializationException(); }  __z = _json2["z"]; }  V3 = new System.Numerics.Vector3(__x, __y,__z); }
        { var _json2 = _json["v4"]; if(!_json2.IsObject) { throw new SerializationException(); } float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } float __z; { if(!_json2["z"].IsNumber) { throw new SerializationException(); }  __z = _json2["z"]; }  float __w; { if(!_json2["w"].IsNumber) { throw new SerializationException(); }  __w = _json2["w"]; } V4 = new System.Numerics.Vector4(__x, __y, __z, __w); }
        { if(!_json["t1"].IsNumber) { throw new SerializationException(); }  T1 = _json["t1"]; }
    }

    public DemoPrimitiveTypesTable(bool x1, byte x2, short x3, int x4, long x5, float x6, double x7, string s1, string s2, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4, int t1 ) 
    {
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.X5 = x5;
        this.X6 = x6;
        this.X7 = x7;
        this.S1 = s1;
        this.S2 = s2;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        this.T1 = t1;
    }

    public static DemoPrimitiveTypesTable DeserializeDemoPrimitiveTypesTable(JSONNode _json)
    {
        return new test.DemoPrimitiveTypesTable(_json);
    }

    public bool X1 { get; private set; }
    public byte X2 { get; private set; }
    public short X3 { get; private set; }
    public int X4 { get; private set; }
    public long X5 { get; private set; }
    public float X6 { get; private set; }
    public double X7 { get; private set; }
    public string S1 { get; private set; }
    public string S2 { get; private set; }
    public string S2_l10n_key { get; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public System.Numerics.Vector3 V3 { get; private set; }
    public System.Numerics.Vector4 V4 { get; private set; }
    public int T1 { get; private set; }

    public const int ID = -370934083;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S2 = translator(S2_l10n_key, S2);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X7:" + X7 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "}";
    }
    }
}
