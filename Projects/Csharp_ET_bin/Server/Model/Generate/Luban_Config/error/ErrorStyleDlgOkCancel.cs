
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

public sealed partial class ErrorStyleDlgOkCancel :  error.ErrorStyle 
{
    public ErrorStyleDlgOkCancel(ByteBuf _buf)  : base(_buf) 
    {
        Btn1Name = _buf.ReadString();
        Btn2Name = _buf.ReadString();
    }

    public static ErrorStyleDlgOkCancel DeserializeErrorStyleDlgOkCancel(ByteBuf _buf)
    {
        return new error.ErrorStyleDlgOkCancel(_buf);
    }

    public string Btn1Name {get; private set;}
    public string Btn2Name {get; private set;}

    public const int ID = 971221414;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Btn1Name:" + Btn1Name + ","
        + "Btn2Name:" + Btn2Name + ","
        + "}";
    }
    }

}