
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.cost;

import bright.serialization.*;



public final class CostCurrencies extends  cfg.cost.Cost 
{
    public CostCurrencies(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());currencies = new java.util.ArrayList<cfg.cost.CostCurrency>(n);for(var i = 0 ; i < n ; i++) { cfg.cost.CostCurrency _e;  _e = cfg.cost.CostCurrency.deserializeCostCurrency(_buf); currencies.add(_e);}}
    }

    public CostCurrencies(java.util.ArrayList<cfg.cost.CostCurrency> currencies )
    {
        super();
        this.currencies = currencies;
    }

    public static CostCurrencies deserializeCostCurrencies(ByteBuf _buf)
    {
        return new CostCurrencies(_buf);
    }

    public final java.util.ArrayList<cfg.cost.CostCurrency> currencies;

    public static final int ID = 103084157;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        super.resolve(_tables);
            for(cfg.cost.CostCurrency _e : currencies) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString()
    {
        return "{ "
        + "currencies:" + currencies + ","
        + "}";
    }
}

