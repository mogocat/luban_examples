
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.cost;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class CostCurrency extends cfg.cost.Cost {
    public CostCurrency(JsonObject __json__) { 
        super(__json__);
        type = cfg.item.ECurrencyType.valueOf(__json__.get("type").getAsInt());
        num = __json__.get("num").getAsInt();
    }

    public CostCurrency(cfg.item.ECurrencyType type, int num ) {
        super();
        this.type = type;
        this.num = num;
    }

    public static CostCurrency deserializeCostCurrency(JsonObject __json__) {
        return new CostCurrency(__json__);
    }

    public final cfg.item.ECurrencyType type;
    public final int num;

    public static final int __ID__ = 911838111;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "type:" + type + ","
        + "num:" + num + ","
        + "}";
    }
}
