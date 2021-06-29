
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
   
public abstract partial class Method :  Bright.Config.BeanBase 
{
    public Method(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        IsStatic = _buf.ReadBool();
        ReturnType = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(n);for(var i = 0 ; i < n ; i++) { blueprint.ParamInfo _e;  _e = blueprint.ParamInfo.DeserializeParamInfo(_buf); Parameters.Add(_e);}}
    }

    public Method(string name, string desc, bool is_static, string return_type, System.Collections.Generic.List<blueprint.ParamInfo> parameters ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.IsStatic = is_static;
        this.ReturnType = return_type;
        this.Parameters = parameters;
    }

    public static Method DeserializeMethod(ByteBuf _buf)
    {
    
        switch (_buf.ReadInt())
        {
            case 0 : return null;
            case blueprint.AbstraceMethod.ID: return new blueprint.AbstraceMethod(_buf);
            case blueprint.ExternalMethod.ID: return new blueprint.ExternalMethod(_buf);
            case blueprint.BlueprintMethod.ID: return new blueprint.BlueprintMethod(_buf);
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

