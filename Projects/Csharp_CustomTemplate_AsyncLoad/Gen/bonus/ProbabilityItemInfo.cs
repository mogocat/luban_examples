
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

public sealed class ProbabilityItemInfo :  Bright.Config.BeanBase 
{
    public ProbabilityItemInfo(JsonElement _json) 
    {
        ItemId = _json.GetProperty("item_id").GetInt32();
        Num = _json.GetProperty("num").GetInt32();
        Probability = _json.GetProperty("probability").GetSingle();
    }

    public ProbabilityItemInfo(int item_id, int num, float probability ) 
    {
        this.ItemId = item_id;
        this.Num = num;
        this.Probability = probability;
    }

    public static ProbabilityItemInfo DeserializeProbabilityItemInfo(JsonElement _json)
    {
        return new bonus.ProbabilityItemInfo(_json);
    }

    public int ItemId { get; private set; }
    public item.Item ItemId_Ref { get; private set; }
    public int Num { get; private set; }
    public float Probability { get; private set; }

    public const int __ID__ = 1547874631;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Num:" + Num + ","
        + "Probability:" + Probability + ","
        + "}";
    }
    }
}