
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
   
public sealed partial class ErrorStyleMsgbox :  error.ErrorStyle 
{
    public ErrorStyleMsgbox(ByteBuf _buf)  : base(_buf) 
    {
        BtnName = _buf.ReadString();
        Operation = (error.EOperation)_buf.ReadInt();
    }

    public ErrorStyleMsgbox(string btn_name, error.EOperation operation )  : base() 
    {
        this.BtnName = btn_name;
        this.Operation = operation;
    }

    public static ErrorStyleMsgbox DeserializeErrorStyleMsgbox(ByteBuf _buf)
    {
    
        return new error.ErrorStyleMsgbox(_buf);
    
    }

     public readonly string BtnName;
     public readonly error.EOperation Operation;


    public const int ID = -1920482343;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "BtnName:" + BtnName + ","
        + "Operation:" + Operation + ","
        + "}";
    }
    }

}

