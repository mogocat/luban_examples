
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
public sealed partial class ErrorStyleDlgOk :  error.ErrorStyle 
{
    public ErrorStyleDlgOk(JSONNode _json)  : base(_json) 
    {
        { if(!_json["btn_name"].IsString) { throw new SerializationException(); }  BtnName = _json["btn_name"]; }
    }

    public ErrorStyleDlgOk(string btn_name )  : base() 
    {
        this.BtnName = btn_name;
    }

    public static ErrorStyleDlgOk DeserializeErrorStyleDlgOk(JSONNode _json)
    {
        return new error.ErrorStyleDlgOk(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly string BtnName;

    public const int ID = -2010134516;
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
        + "BtnName:" + BtnName + ","
        + "}";
    }
    }
}
