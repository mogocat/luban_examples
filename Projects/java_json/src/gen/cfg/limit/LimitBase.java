
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.limit;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public abstract class LimitBase {
    public LimitBase(JsonObject __json__) { 
    }

    public LimitBase() {
    }

    public static LimitBase deserializeLimitBase(JsonObject __json__) {
        switch (__json__.get("__type__").getAsString()) {
            case "DailyLimit": return new cfg.limit.DailyLimit(__json__);
            case "MultiDayLimit": return new cfg.limit.MultiDayLimit(__json__);
            case "WeeklyLimit": return new cfg.limit.WeeklyLimit(__json__);
            case "MonthlyLimit": return new cfg.limit.MonthlyLimit(__json__);
            case "CoolDown": return new cfg.limit.CoolDown(__json__);
            case "GroupCoolDown": return new cfg.limit.GroupCoolDown(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }


    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "}";
    }
}