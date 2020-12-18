
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.error
{
   
public sealed partial class ErrorInfo :  Bright.Config.BeanBase 
{
    public ErrorInfo(JsonElement _buf) 
    {
        Code = _buf.GetProperty("code").GetString();
        Desc = _buf.GetProperty("desc").GetString();
        { var _j = _buf.GetProperty("style"); if (_j.ValueKind != JsonValueKind.Null) { Style =  error.ErrorStyle.DeserializeErrorStyle(_j); } else { Style = null; } }
    }

    public ErrorInfo(string code, string desc, error.ErrorStyle style ) 
    {
        this.Code = code;
        this.Desc = desc;
        this.Style = style;
    }

    public static ErrorInfo DeserializeErrorInfo(JsonElement _buf)
    {
    
        return new error.ErrorInfo(_buf);
    
    }

     public readonly string Code;
     public readonly string Desc;
     public readonly error.ErrorStyle Style;


    public const int ID = 1389347408;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

            Style?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Code:" + Code + ","
        + "Desc:" + Desc + ","
        + "Style:" + Style + ","
        + "}";
    }
    }
}
