
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



public final class OneItem extends cfg.bonus.Bonus {
    public OneItem(JsonObject __json__) { 
        super(__json__);
        itemId = __json__.get("item_id").getAsInt();
    }

    public OneItem(int item_id ) {
        super();
        this.itemId = item_id;
    }

    public static OneItem deserializeOneItem(JsonObject __json__) {
        return new OneItem(__json__);
    }

    public final int itemId;
    public cfg.item.Item itemId_Ref;

    public static final int __ID__ = -1649658966;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        this.itemId_Ref = ((cfg.item.TbItem)_tables.get("item.TbItem")).get(itemId);
    }

    @Override
    public String toString() {
        return "{ "
        + "itemId:" + itemId + ","
        + "}";
    }
}
