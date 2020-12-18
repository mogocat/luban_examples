
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
   
public sealed partial class ParamInfo :  Bright.Config.BeanBase 
{
    public ParamInfo(JsonElement _buf) 
    {
        Name = _buf.GetProperty("name").GetString();
        Type = _buf.GetProperty("type").GetString();
        IsRef = _buf.GetProperty("is_ref").GetBoolean();
    }

    public ParamInfo(string name, string type, bool is_ref ) 
    {
        this.Name = name;
        this.Type = type;
        this.IsRef = is_ref;
    }

    public static ParamInfo DeserializeParamInfo(JsonElement _buf)
    {
    
        return new blueprint.ParamInfo(_buf);
    
    }

     public readonly string Name;
     public readonly string Type;
     public readonly bool IsRef;


    public const int ID = -729799392;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "IsRef:" + IsRef + ","
        + "}";
    }
    }
}

