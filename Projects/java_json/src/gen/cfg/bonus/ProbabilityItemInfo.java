
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.bonus;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class ProbabilityItemInfo {
    public ProbabilityItemInfo(JsonObject __json__) { 
        itemId = __json__.get("item_id").getAsInt();
        num = __json__.get("num").getAsInt();
        probability = __json__.get("probability").getAsFloat();
    }

    public ProbabilityItemInfo(int item_id, int num, float probability ) {
        this.itemId = item_id;
        this.num = num;
        this.probability = probability;
    }

    public static ProbabilityItemInfo deserializeProbabilityItemInfo(JsonObject __json__) {
        return new ProbabilityItemInfo(__json__);
    }

    public final int itemId;
    public cfg.item.Item itemId_Ref;
    public final int num;
    public final float probability;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        this.itemId_Ref = ((cfg.item.TbItem)_tables.get("item.TbItem")).get(itemId);
    }

    @Override
    public String toString() {
        return "{ "
        + "itemId:" + itemId + ","
        + "num:" + num + ","
        + "probability:" + probability + ","
        + "}";
    }
}