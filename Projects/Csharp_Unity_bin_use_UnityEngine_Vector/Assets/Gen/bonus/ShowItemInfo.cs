
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

/// <summary>
/// 
/// </summary>
public sealed partial class ShowItemInfo :  Bright.Config.BeanBase 
{
    public ShowItemInfo(ByteBuf _buf) 
    {
        ItemId = _buf.ReadInt();
        ItemNum = _buf.ReadLong();
    }

    public ShowItemInfo(int item_id, long item_num ) 
    {
        this.ItemId = item_id;
        this.ItemNum = item_num;
    }

    public static ShowItemInfo DeserializeShowItemInfo(ByteBuf _buf)
    {
        return new bonus.ShowItemInfo(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int ItemId;
    public item.Item ItemId_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly long ItemNum;

    public const int ID = -1496363507;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "ItemNum:" + ItemNum + ","
        + "}";
    }
    }

}

