
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.error
{

public abstract class ErrorStyle :  Bright.Config.BeanBase 
{
    public ErrorStyle(ByteBuf _buf) 
    {
    }

    public static ErrorStyle DeserializeErrorStyle(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case error.ErrorStyleTip.ID: return new error.ErrorStyleTip(_buf);
            case error.ErrorStyleMsgbox.ID: return new error.ErrorStyleMsgbox(_buf);
            case error.ErrorStyleDlgOk.ID: return new error.ErrorStyleDlgOk(_buf);
            case error.ErrorStyleDlgOkCancel.ID: return new error.ErrorStyleDlgOkCancel(_buf);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }

}
