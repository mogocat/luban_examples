
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
   
public sealed partial class EnumClazz :  blueprint.Clazz 
{
    public EnumClazz(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("enums"); Enums = new System.Collections.Generic.List<blueprint.EnumField>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { blueprint.EnumField __v;  __v =  blueprint.EnumField.DeserializeEnumField(__e);  Enums.Add(__v); }   }
    }

    public EnumClazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods, System.Collections.Generic.List<blueprint.EnumField> enums )  : base(name,desc,parents,methods) 
    {
        this.Enums = enums;
    }

    public static EnumClazz DeserializeEnumClazz(JsonElement _buf)
    {
    
        return new blueprint.EnumClazz(_buf);
    
    }

     public readonly System.Collections.Generic.List<blueprint.EnumField> Enums;


    public const int ID = 1827364892;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            foreach(var _e in Enums) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Parents + ","
        + "Methods:" + Methods + ","
        + "Enums:" + Enums + ","
        + "}";
    }
    }
}
