
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



namespace cfg.ai
{
   
public sealed partial class BinaryOperator :  ai.KeyQueryOperator 
{
    public BinaryOperator(JsonElement _buf)  : base(_buf) 
    {
        Oper = (ai.EOperator)_buf.GetProperty("oper").GetInt32();
        { var _j = _buf.GetProperty("data"); if (_j.ValueKind != JsonValueKind.Null) { Data =  ai.KeyData.DeserializeKeyData(_j); } else { Data = null; } }
    }

    public BinaryOperator(ai.EOperator oper, ai.KeyData data )  : base() 
    {
        this.Oper = oper;
        this.Data = data;
    }

    public static BinaryOperator DeserializeBinaryOperator(JsonElement _buf)
    {
    
        return new ai.BinaryOperator(_buf);
    
    }

     public readonly ai.EOperator Oper;
     public readonly ai.KeyData Data;


    public const int ID = -979891605;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            Data?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Oper:" + Oper + ","
        + "Data:" + Data + ","
        + "}";
    }
    }
}

