
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



public final class CostItems extends cfg.cost.Cost {
    public CostItems(JsonObject __json__) { 
        super(__json__);
        { com.google.gson.JsonArray _json0_ = __json__.get("item_list").getAsJsonArray(); int _n = _json0_.size(); itemList = new cfg.cost.CostItem[_n]; int _index=0; for(JsonElement __e : _json0_) { cfg.cost.CostItem __v;  __v = new cfg.cost.CostItem(__e.getAsJsonObject());  itemList[_index++] = __v; }   }
    }

    public CostItems(cfg.cost.CostItem[] item_list ) {
        super();
        this.itemList = item_list;
    }

    public static CostItems deserializeCostItems(JsonObject __json__) {
        return new CostItems(__json__);
    }

    public final cfg.cost.CostItem[] itemList;

    public static final int __ID__ = -77945102;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.cost.CostItem _e : itemList) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "itemList:" + itemList + ","
        + "}";
    }
}
