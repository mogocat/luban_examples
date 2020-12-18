
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{
   
public abstract partial class Clazz :  Bright.Config.BeanBase 
{
    public Clazz(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Parents = new System.Collections.Generic.List<blueprint.Clazz>(n);for(var i = 0 ; i < n ; i++) { blueprint.Clazz _e;  _e = blueprint.Clazz.DeserializeClazz(_buf); Parents.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Methods = new System.Collections.Generic.List<blueprint.Method>(n);for(var i = 0 ; i < n ; i++) { blueprint.Method _e;  _e = blueprint.Method.DeserializeMethod(_buf); Methods.Add(_e);}}
    }

    public Clazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.Parents = parents;
        this.Methods = methods;
    }

    public static Clazz DeserializeClazz(ByteBuf _buf)
    {
    
        switch (_buf.ReadInt())
        {
            case 0 : return null;
            case blueprint.Interface.ID: return new blueprint.Interface(_buf);
            case blueprint.NormalClazz.ID: return new blueprint.NormalClazz(_buf);
            case blueprint.EnumClazz.ID: return new blueprint.EnumClazz(_buf);
            default: throw new SerializationException();
        }
    
    }

     public readonly string Name;
     public readonly string Desc;
     public readonly System.Collections.Generic.List<blueprint.Clazz> Parents;
     public readonly System.Collections.Generic.List<blueprint.Method> Methods;



    public virtual void Resolve(Dictionary<string, object> _tables)
    {

            foreach(var _e in Parents) { _e?.Resolve(_tables); }
            foreach(var _e in Methods) { _e?.Resolve(_tables); }
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
        + "}";
    }
    }

}

