
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;


public final class TbSingleton {
    private final cfg.test.DemoSingletonType _data;

    public final cfg.test.DemoSingletonType data() { return _data; }

    public TbSingleton(JsonElement __json__) {
        int n = __json__.getAsJsonArray().size();
        if (n != 1) throw new bright.serialization.SerializationException("table mode=one, but size != 1");
        _data = new cfg.test.DemoSingletonType(__json__.getAsJsonArray().get(0).getAsJsonObject());
    }


     public int getId() { return _data.id; }
     public String getName() { return _data.name; }
     public cfg.test.DemoDynamic getDate() { return _data.date; }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        _data.resolve(_tables);
    }

}