
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.l10n;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class L10NDemo {
    public L10NDemo(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        __json__.get("text").getAsJsonObject().get("key").getAsString(); text = __json__.get("text").getAsJsonObject().get("text").getAsString();
    }

    public L10NDemo(int id, String text ) {
        this.id = id;
        this.text = text;
    }

    public static L10NDemo deserializeL10NDemo(JsonObject __json__) {
        return new L10NDemo(__json__);
    }

    public final int id;
    public final String text;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "text:" + text + ","
        + "}";
    }
}
