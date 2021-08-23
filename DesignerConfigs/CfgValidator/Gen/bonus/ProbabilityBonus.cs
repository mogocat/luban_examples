
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

public sealed partial class ProbabilityBonus :  bonus.Bonus 
{
    public ProbabilityBonus(JsonElement _json)  : base(_json) 
    {
        { var _json0 = _json.GetProperty("bonuses"); int _n = _json0.GetArrayLength(); Bonuses = new bonus.ProbabilityBonusInfo[_n]; int _index=0; foreach(JsonElement __e in _json0.EnumerateArray()) { bonus.ProbabilityBonusInfo __v;  __v =  bonus.ProbabilityBonusInfo.DeserializeProbabilityBonusInfo(__e);  Bonuses[_index++] = __v; }   }
    }

    public ProbabilityBonus(bonus.ProbabilityBonusInfo[] bonuses )  : base() 
    {
        this.Bonuses = bonuses;
    }

    public static ProbabilityBonus DeserializeProbabilityBonus(JsonElement _json)
    {
        return new bonus.ProbabilityBonus(_json);
    }

    public readonly bonus.ProbabilityBonusInfo[] Bonuses;

    public const int ID = 359783161;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Bonuses) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Bonuses:" + Bright.Common.StringUtil.CollectionToString(Bonuses) + ","
        + "}";
    }
    }
}

