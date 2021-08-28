
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



public abstract class Decorator extends cfg.ai.Node {
    public Decorator(JsonObject __json__) { 
        super(__json__);
        flowAbortMode = cfg.ai.EFlowAbortMode.valueOf(__json__.get("flow_abort_mode").getAsInt());
    }

    public Decorator(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode ) {
        super(id, node_name);
        this.flowAbortMode = flow_abort_mode;
    }

    public static Decorator deserializeDecorator(JsonObject __json__) {
        switch (__json__.get("__type__").getAsString()) {
            case "UeLoop": return new cfg.ai.UeLoop(__json__);
            case "UeCooldown": return new cfg.ai.UeCooldown(__json__);
            case "UeTimeLimit": return new cfg.ai.UeTimeLimit(__json__);
            case "UeBlackboard": return new cfg.ai.UeBlackboard(__json__);
            case "UeForceSuccess": return new cfg.ai.UeForceSuccess(__json__);
            case "IsAtLocation": return new cfg.ai.IsAtLocation(__json__);
            case "DistanceLessThan": return new cfg.ai.DistanceLessThan(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }

    public final cfg.ai.EFlowAbortMode flowAbortMode;


    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "}";
    }
}