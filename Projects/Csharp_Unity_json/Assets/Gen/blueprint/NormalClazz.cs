
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



namespace cfg.blueprint
{

/// <summary>
/// 
/// </summary>
public sealed partial class NormalClazz :  blueprint.Clazz 
{
    public NormalClazz(JSONNode _json)  : base(_json) 
    {
        { if(!_json["is_abstract"].IsBoolean) { throw new SerializationException(); }  IsAbstract = _json["is_abstract"]; }
        { var _json1 = _json["fields"]; if(!_json1.IsArray) { throw new SerializationException(); } Fields = new System.Collections.Generic.List<blueprint.Field>(_json1.Count); foreach(JSONNode __e in _json1.Children) { blueprint.Field __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = blueprint.Field.DeserializeField(__e); }  Fields.Add(__v); }   }
    }

    public NormalClazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods, bool is_abstract, System.Collections.Generic.List<blueprint.Field> fields )  : base(name,desc,parents,methods) 
    {
        this.IsAbstract = is_abstract;
        this.Fields = fields;
    }

    public static NormalClazz DeserializeNormalClazz(JSONNode _json)
    {
        return new blueprint.NormalClazz(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly bool IsAbstract;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<blueprint.Field> Fields;

    public const int ID = -2073576778;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Fields) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "IsAbstract:" + IsAbstract + ","
        + "Fields:" + Bright.Common.StringUtil.CollectionToString(Fields) + ","
        + "}";
    }
    }
}
