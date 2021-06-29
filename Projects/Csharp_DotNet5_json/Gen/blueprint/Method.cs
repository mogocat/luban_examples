
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



namespace cfg.blueprint
{
   
public abstract partial class Method :  Bright.Config.BeanBase 
{
    public Method(JsonElement _buf) 
    {
        Name = _buf.GetProperty("name").GetString();
        Desc = _buf.GetProperty("desc").GetString();
        IsStatic = _buf.GetProperty("is_static").GetBoolean();
        ReturnType = _buf.GetProperty("return_type").GetString();
        { var _json = _buf.GetProperty("parameters"); Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { blueprint.ParamInfo __v;  __v =  blueprint.ParamInfo.DeserializeParamInfo(__e);  Parameters.Add(__v); }   }
    }

    public Method(string name, string desc, bool is_static, string return_type, System.Collections.Generic.List<blueprint.ParamInfo> parameters ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.IsStatic = is_static;
        this.ReturnType = return_type;
        this.Parameters = parameters;
    }

    public static Method DeserializeMethod(JsonElement _buf)
    {
        switch (_buf.GetProperty("__type__").GetString())
        {
            case "AbstraceMethod": return new blueprint.AbstraceMethod(_buf);
            case "ExternalMethod": return new blueprint.ExternalMethod(_buf);
            case "BlueprintMethod": return new blueprint.BlueprintMethod(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly string Name;
    public readonly string Desc;
    public readonly bool IsStatic;
    public readonly string ReturnType;
    public readonly System.Collections.Generic.List<blueprint.ParamInfo> Parameters;


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parameters) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }
    }
}

