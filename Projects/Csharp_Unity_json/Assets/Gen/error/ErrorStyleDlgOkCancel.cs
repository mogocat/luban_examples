
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



namespace cfg.error
{

/// <summary>
/// 
/// </summary>
public sealed partial class ErrorStyleDlgOkCancel :  error.ErrorStyle 
{
    public ErrorStyleDlgOkCancel(JSONNode _json)  : base(_json) 
    {
        { if(!_json["btn1_name"].IsString) { throw new SerializationException(); }  Btn1Name = _json["btn1_name"]; }
        { if(!_json["btn2_name"].IsString) { throw new SerializationException(); }  Btn2Name = _json["btn2_name"]; }
    }

    public ErrorStyleDlgOkCancel(string btn1_name, string btn2_name )  : base() 
    {
        this.Btn1Name = btn1_name;
        this.Btn2Name = btn2_name;
    }

    public static ErrorStyleDlgOkCancel DeserializeErrorStyleDlgOkCancel(JSONNode _json)
    {
        return new error.ErrorStyleDlgOkCancel(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly string Btn1Name;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Btn2Name;

    public const int ID = 971221414;
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
        + "Btn1Name:" + Btn1Name + ","
        + "Btn2Name:" + Btn2Name + ","
        + "}";
    }
    }
}
