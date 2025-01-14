
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.bonus
{

public sealed class CoefficientItem :  bonus.Bonus 
{
    public CoefficientItem(JSONNode _json)  : base(_json) 
    {
        { if(!_json["bonus_id"].IsNumber) { throw new SerializationException(); }  BonusId = _json["bonus_id"]; }
        { if(!_json["bonus_list"].IsObject) { throw new SerializationException(); }  BonusList = bonus.Items.DeserializeItems(_json["bonus_list"]); }
    }

    public CoefficientItem(int bonus_id, bonus.Items bonus_list )  : base() 
    {
        this.BonusId = bonus_id;
        this.BonusList = bonus_list;
    }

    public static CoefficientItem DeserializeCoefficientItem(JSONNode _json)
    {
        return new bonus.CoefficientItem(_json);
    }

    public int BonusId { get; private set; }
    public bonus.Items BonusList { get; private set; }

    public const int __ID__ = -229470727;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        BonusList?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        BonusList?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "BonusId:" + BonusId + ","
        + "BonusList:" + BonusList + ","
        + "}";
    }
    }
}
