
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

public abstract class Method :  Bright.Config.BeanBase 
{
    public Method(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        IsStatic = _buf.ReadBool();
        ReturnType = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(n);for(var i = 0 ; i < n ; i++) { blueprint.ParamInfo _e;  _e = blueprint.ParamInfo.DeserializeParamInfo(_buf); Parameters.Add(_e);}}
    }

    public static Method DeserializeMethod(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case blueprint.AbstraceMethod.ID: return new blueprint.AbstraceMethod(_buf);
            case blueprint.ExternalMethod.ID: return new blueprint.ExternalMethod(_buf);
            case blueprint.BlueprintMethod.ID: return new blueprint.BlueprintMethod(_buf);
            default: throw new SerializationException();
        }
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public bool IsStatic { get; private set; }
    public string ReturnType { get; private set; }
    public System.Collections.Generic.List<blueprint.ParamInfo> Parameters { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parameters) { _e?.Resolve(_tables); }
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parameters) { _e?.TranslateText(translator); }
    }

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
