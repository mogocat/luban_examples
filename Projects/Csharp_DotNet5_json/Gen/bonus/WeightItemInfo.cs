
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



namespace cfg.bonus
{
   
public sealed partial class WeightItemInfo :  Bright.Config.BeanBase 
{
    public WeightItemInfo(JsonElement _buf) 
    {
        ItemId = _buf.GetProperty("item_id").GetInt32();
        Num = _buf.GetProperty("num").GetInt32();
        Weight = _buf.GetProperty("weight").GetInt32();
    }

    public WeightItemInfo(int item_id, int num, int weight ) 
    {
        this.ItemId = item_id;
        this.Num = num;
        this.Weight = weight;
    }

    public static WeightItemInfo DeserializeWeightItemInfo(JsonElement _buf)
    {
    
        return new bonus.WeightItemInfo(_buf);
    
    }

    public readonly int ItemId;
    public item.Item ItemId_Ref;
    public readonly int Num;
    public readonly int Weight;


    public const int ID = 1239999176;
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
        + "Num:" + Num + ","
        + "Weight:" + Weight + ","
        + "}";
    }
    }
}

