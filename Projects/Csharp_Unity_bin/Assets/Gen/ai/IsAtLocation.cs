
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

/// <summary>
/// 
/// </summary>
public sealed partial class IsAtLocation :  ai.Decorator 
{
    public IsAtLocation(ByteBuf _buf)  : base(_buf) 
    {
        AcceptableRadius = _buf.ReadFloat();
        KeyboardKey = _buf.ReadString();
        InverseCondition = _buf.ReadBool();
    }

    public IsAtLocation(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, float acceptable_radius, string keyboard_key, bool inverse_condition )  : base(id,node_name,flow_abort_mode) 
    {
        this.AcceptableRadius = acceptable_radius;
        this.KeyboardKey = keyboard_key;
        this.InverseCondition = inverse_condition;
    }

    public static IsAtLocation DeserializeIsAtLocation(ByteBuf _buf)
    {
        return new ai.IsAtLocation(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly float AcceptableRadius;
    /// <summary>
    /// 
    /// </summary>
    public readonly string KeyboardKey;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool InverseCondition;

    public const int ID = 1255972344;
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
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "KeyboardKey:" + KeyboardKey + ","
        + "InverseCondition:" + InverseCondition + ","
        + "}";
    }
    }

}

