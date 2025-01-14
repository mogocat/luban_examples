
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

public abstract class Clazz :  Bright.Config.BeanBase 
{
    public Clazz(JSONNode _json) 
    {
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { var _json1 = _json["parents"]; if(!_json1.IsArray) { throw new SerializationException(); } Parents = new System.Collections.Generic.List<blueprint.Clazz>(_json1.Count); foreach(JSONNode __e in _json1.Children) { blueprint.Clazz __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = blueprint.Clazz.DeserializeClazz(__e); }  Parents.Add(__v); }   }
        { var _json1 = _json["methods"]; if(!_json1.IsArray) { throw new SerializationException(); } Methods = new System.Collections.Generic.List<blueprint.Method>(_json1.Count); foreach(JSONNode __e in _json1.Children) { blueprint.Method __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = blueprint.Method.DeserializeMethod(__e); }  Methods.Add(__v); }   }
    }

    public Clazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.Parents = parents;
        this.Methods = methods;
    }

    public static Clazz DeserializeClazz(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "Interface": return new blueprint.Interface(_json);
            case "NormalClazz": return new blueprint.NormalClazz(_json);
            case "EnumClazz": return new blueprint.EnumClazz(_json);
            default: throw new SerializationException();
        }
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public System.Collections.Generic.List<blueprint.Clazz> Parents { get; private set; }
    public System.Collections.Generic.List<blueprint.Method> Methods { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parents) { _e?.Resolve(_tables); }
        foreach(var _e in Methods) { _e?.Resolve(_tables); }
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parents) { _e?.TranslateText(translator); }
        foreach(var _e in Methods) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "}";
    }
    }
}
