
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.tag;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class TestTag {
    public TestTag(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        value = __json__.get("value").getAsString();
    }

    public TestTag(int id, String value ) {
        this.id = id;
        this.value = value;
    }

    public static TestTag deserializeTestTag(JsonObject __json__) {
        return new TestTag(__json__);
    }

    public final int id;
    public final String value;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "value:" + value + ","
        + "}";
    }
}