
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
   
public sealed partial class NormalClazz :  blueprint.Clazz 
{
    public NormalClazz(ByteBuf _buf)  : base(_buf) 
    {
        IsAbstract = _buf.ReadBool();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Fields = new System.Collections.Generic.List<blueprint.Field>(n);for(var i = 0 ; i < n ; i++) { blueprint.Field _e;  _e = blueprint.Field.DeserializeField(_buf); Fields.Add(_e);}}
    }

    public NormalClazz(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods, bool is_abstract, System.Collections.Generic.List<blueprint.Field> fields )  : base(name,desc,parents,methods) 
    {
        this.IsAbstract = is_abstract;
        this.Fields = fields;
    }

    public static NormalClazz DeserializeNormalClazz(ByteBuf _buf)
    {
    
        return new blueprint.NormalClazz(_buf);
    
    }

     public readonly bool IsAbstract;
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
        + "Parents:" + Parents + ","
        + "Methods:" + Methods + ","
        + "IsAbstract:" + IsAbstract + ","
        + "Fields:" + Fields + ","
        + "}";
    }
    }

}

