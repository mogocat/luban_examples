
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



namespace cfg.cost
{

public sealed class CostCurrencies :  cost.Cost 
{
    public CostCurrencies(JSONNode _json)  : base(_json) 
    {
        { var _json1 = _json["currencies"]; if(!_json1.IsArray) { throw new SerializationException(); } Currencies = new System.Collections.Generic.List<cost.CostCurrency>(_json1.Count); foreach(JSONNode __e in _json1.Children) { cost.CostCurrency __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = cost.CostCurrency.DeserializeCostCurrency(__e); }  Currencies.Add(__v); }   }
    }

    public CostCurrencies(System.Collections.Generic.List<cost.CostCurrency> currencies )  : base() 
    {
        this.Currencies = currencies;
    }

    public static CostCurrencies DeserializeCostCurrencies(JSONNode _json)
    {
        return new cost.CostCurrencies(_json);
    }

    public System.Collections.Generic.List<cost.CostCurrency> Currencies { get; private set; }

    public const int __ID__ = 103084157;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Currencies) { _e?.Resolve(_tables); }
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Currencies) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Currencies:" + Bright.Common.StringUtil.CollectionToString(Currencies) + ","
        + "}";
    }
    }
}
