
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



namespace cfg.error
{
   
public sealed partial class CodeInfo :  Bright.Config.BeanBase 
{
    public CodeInfo(JsonElement _buf) 
    {
        Code = (error.EErrorCode)_buf.GetProperty("code").GetInt32();
        Key = _buf.GetProperty("key").GetString();
    }

    public CodeInfo(error.EErrorCode code, string key ) 
    {
        this.Code = code;
        this.Key = key;
    }

    public static CodeInfo DeserializeCodeInfo(JsonElement _buf)
    {
    
        return new error.CodeInfo(_buf);
    
    }

    public readonly error.EErrorCode Code;
    public readonly string Key;


    public const int ID = -1942481535;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Code:" + Code + ","
        + "Key:" + Key + ","
        + "}";
    }
    }
}

