
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class DemoGroup {
    public DemoGroup(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        x1 = __json__.get("x1").getAsInt();
        x2 = __json__.get("x2").getAsInt();
        x3 = __json__.get("x3").getAsInt();
        x4 = __json__.get("x4").getAsInt();
        x5 = new cfg.test.InnerGroup(__json__.get("x5").getAsJsonObject());
    }

    public DemoGroup(int id, int x1, int x2, int x3, int x4, cfg.test.InnerGroup x5 ) {
        this.id = id;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
        this.x5 = x5;
    }

    public static DemoGroup deserializeDemoGroup(JsonObject __json__) {
        return new DemoGroup(__json__);
    }

    public final int id;
    public final int x1;
    public final int x2;
    public final int x3;
    public final int x4;
    public final cfg.test.InnerGroup x5;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (x5 != null) {x5.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "x5:" + x5 + ","
        + "}";
    }
}