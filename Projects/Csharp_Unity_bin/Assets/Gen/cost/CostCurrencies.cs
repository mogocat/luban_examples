
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.cost
{
   
public sealed partial class CostCurrencies :  cost.Cost 
{
    public CostCurrencies(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Currencies = new System.Collections.Generic.List<cost.CostCurrency>(n);for(var i = 0 ; i < n ; i++) { cost.CostCurrency _e;  _e = cost.CostCurrency.DeserializeCostCurrency(_buf); Currencies.Add(_e);}}
    }

    public CostCurrencies(System.Collections.Generic.List<cost.CostCurrency> currencies )  : base() 
    {
        this.Currencies = currencies;
    }

    public static CostCurrencies DeserializeCostCurrencies(ByteBuf _buf)
    {
    
        return new cost.CostCurrencies(_buf);
    
    }

     public readonly System.Collections.Generic.List<cost.CostCurrency> Currencies;


    public const int ID = 103084157;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            foreach(var _e in Currencies) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Currencies:" + Currencies + ","
        + "}";
    }
    }

}

