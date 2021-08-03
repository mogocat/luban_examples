
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{

/// <summary>
/// 
/// </summary>
public sealed partial class ContainsItem :  condition.RoleCondition 
{
    public ContainsItem(ByteBuf _buf)  : base(_buf) 
    {
        ItemId = _buf.ReadInt();
        Num = _buf.ReadInt();
        Reverse = _buf.ReadBool();
    }

    public ContainsItem(int item_id, int num, bool reverse )  : base() 
    {
        this.ItemId = item_id;
        this.Num = num;
        this.Reverse = reverse;
    }

    public static ContainsItem DeserializeContainsItem(ByteBuf _buf)
    {
        return new condition.ContainsItem(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int ItemId;
    public item.Item ItemId_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly int Num;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool Reverse;

    public const int ID = 1961145317;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Num:" + Num + ","
        + "Reverse:" + Reverse + ","
        + "}";
    }
    }

}

