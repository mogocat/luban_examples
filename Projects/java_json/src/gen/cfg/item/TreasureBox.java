
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.item;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class TreasureBox extends cfg.item.ItemExtra {
    public TreasureBox(JsonObject __json__) { 
        super(__json__);
        { if (__json__.has("key_item_id") && !__json__.get("key_item_id").isJsonNull()) { keyItemId = __json__.get("key_item_id").getAsInt(); } else { keyItemId = null; } }
        openLevel = new cfg.condition.MinLevel(__json__.get("open_level").getAsJsonObject());
        useOnObtain = __json__.get("use_on_obtain").getAsBoolean();
        { com.google.gson.JsonArray _json0_ = __json__.get("drop_ids").getAsJsonArray(); dropIds = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  dropIds.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("choose_list").getAsJsonArray(); chooseList = new java.util.ArrayList<cfg.item.ChooseOneBonus>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.item.ChooseOneBonus __v;  __v = new cfg.item.ChooseOneBonus(__e.getAsJsonObject());  chooseList.add(__v); }   }
    }

    public TreasureBox(int id, Integer key_item_id, cfg.condition.MinLevel open_level, boolean use_on_obtain, java.util.ArrayList<Integer> drop_ids, java.util.ArrayList<cfg.item.ChooseOneBonus> choose_list ) {
        super(id);
        this.keyItemId = key_item_id;
        this.openLevel = open_level;
        this.useOnObtain = use_on_obtain;
        this.dropIds = drop_ids;
        this.chooseList = choose_list;
    }

    public static TreasureBox deserializeTreasureBox(JsonObject __json__) {
        return new TreasureBox(__json__);
    }

    public final Integer keyItemId;
    public final cfg.condition.MinLevel openLevel;
    public final boolean useOnObtain;
    public final java.util.ArrayList<Integer> dropIds;
    public final java.util.ArrayList<cfg.item.ChooseOneBonus> chooseList;

    public static final int __ID__ = 1494222369;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        if (openLevel != null) {openLevel.resolve(_tables);}
        for(cfg.item.ChooseOneBonus _e : chooseList) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "keyItemId:" + keyItemId + ","
        + "openLevel:" + openLevel + ","
        + "useOnObtain:" + useOnObtain + ","
        + "dropIds:" + dropIds + ","
        + "chooseList:" + chooseList + ","
        + "}";
    }
}
