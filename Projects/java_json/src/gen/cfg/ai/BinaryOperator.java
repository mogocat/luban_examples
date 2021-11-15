
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class BinaryOperator extends cfg.ai.KeyQueryOperator {
    public BinaryOperator(JsonObject __json__) { 
        super(__json__);
        oper = cfg.ai.EOperator.valueOf(__json__.get("oper").getAsInt());
        data = cfg.ai.KeyData.deserializeKeyData(__json__.get("data").getAsJsonObject());
    }

    public BinaryOperator(cfg.ai.EOperator oper, cfg.ai.KeyData data ) {
        super();
        this.oper = oper;
        this.data = data;
    }

    public static BinaryOperator deserializeBinaryOperator(JsonObject __json__) {
        return new BinaryOperator(__json__);
    }

    public final cfg.ai.EOperator oper;
    public final cfg.ai.KeyData data;

    public static final int __ID__ = -979891605;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        if (data != null) {data.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "oper:" + oper + ","
        + "data:" + data + ","
        + "}";
    }
}
