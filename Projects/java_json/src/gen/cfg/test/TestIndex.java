
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



public final class TestIndex {
    public TestIndex(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        { var _json0_ = __json__.get("eles").getAsJsonArray(); eles = new java.util.ArrayList<cfg.test.DemoType1>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.test.DemoType1 __v;  __v = new cfg.test.DemoType1(__e.getAsJsonObject());  eles.add(__v); }   }
        for(cfg.test.DemoType1 _v : eles) {
            eles_Index.put(_v.x1, _v); 
        }
    }

    public TestIndex(int id, java.util.ArrayList<cfg.test.DemoType1> eles ) {
        this.id = id;
        this.eles = eles;
        for(cfg.test.DemoType1 _v : eles) {
            eles_Index.put(_v.x1, _v); 
        }
    }

    public static TestIndex deserializeTestIndex(JsonObject __json__) {
        return new TestIndex(__json__);
    }

    public final int id;
    public final java.util.ArrayList<cfg.test.DemoType1> eles;
    public final java.util.HashMap<Integer, cfg.test.DemoType1> eles_Index = new java.util.HashMap<>();


    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.DemoType1 _e : eles) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "eles:" + eles + ","
        + "}";
    }
}