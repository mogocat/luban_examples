
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



public final class MultiRowTitle {
    public MultiRowTitle(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        name = __json__.get("name").getAsString();
        x1 = new cfg.test.H1(__json__.get("x1").getAsJsonObject());
        { com.google.gson.JsonArray _json0_ = __json__.get("x2").getAsJsonArray(); x2 = new java.util.ArrayList<cfg.test.H2>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.test.H2 __v;  __v = new cfg.test.H2(__e.getAsJsonObject());  x2.add(__v); }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("x3").getAsJsonArray(); int _n = _json0_.size(); x3 = new cfg.test.H2[_n]; int _index=0; for(JsonElement __e : _json0_) { cfg.test.H2 __v;  __v = new cfg.test.H2(__e.getAsJsonObject());  x3[_index++] = __v; }   }
        { com.google.gson.JsonArray _json0_ = __json__.get("x4").getAsJsonArray(); int _n = _json0_.size(); x4 = new cfg.test.H2[_n]; int _index=0; for(JsonElement __e : _json0_) { cfg.test.H2 __v;  __v = new cfg.test.H2(__e.getAsJsonObject());  x4[_index++] = __v; }   }
    }

    public MultiRowTitle(int id, String name, cfg.test.H1 x1, java.util.ArrayList<cfg.test.H2> x2, cfg.test.H2[] x3, cfg.test.H2[] x4 ) {
        this.id = id;
        this.name = name;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }

    public static MultiRowTitle deserializeMultiRowTitle(JsonObject __json__) {
        return new MultiRowTitle(__json__);
    }

    public final int id;
    public final String name;
    public final cfg.test.H1 x1;
    public final java.util.ArrayList<cfg.test.H2> x2;
    public final cfg.test.H2[] x3;
    public final cfg.test.H2[] x4;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (x1 != null) {x1.resolve(_tables);}
        for(cfg.test.H2 _e : x2) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.H2 _e : x3) { if (_e != null) _e.resolve(_tables); }
        for(cfg.test.H2 _e : x4) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "}";
    }
}
