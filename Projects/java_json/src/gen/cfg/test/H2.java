
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



public final class H2 {
    public H2(JsonObject __json__) { 
        z2 = __json__.get("z2").getAsInt();
        z3 = __json__.get("z3").getAsInt();
    }

    public H2(int z2, int z3 ) {
        this.z2 = z2;
        this.z3 = z3;
    }

    public static H2 deserializeH2(JsonObject __json__) {
        return new H2(__json__);
    }

    public final int z2;
    public final int z3;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "z2:" + z2 + ","
        + "z3:" + z3 + ","
        + "}";
    }
}