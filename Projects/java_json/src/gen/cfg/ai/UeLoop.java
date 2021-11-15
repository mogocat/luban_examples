
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



public final class UeLoop extends cfg.ai.Decorator {
    public UeLoop(JsonObject __json__) { 
        super(__json__);
        numLoops = __json__.get("num_loops").getAsInt();
        infiniteLoop = __json__.get("infinite_loop").getAsBoolean();
        infiniteLoopTimeoutTime = __json__.get("infinite_loop_timeout_time").getAsFloat();
    }

    public UeLoop(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode, int num_loops, boolean infinite_loop, float infinite_loop_timeout_time ) {
        super(id, node_name, flow_abort_mode);
        this.numLoops = num_loops;
        this.infiniteLoop = infinite_loop;
        this.infiniteLoopTimeoutTime = infinite_loop_timeout_time;
    }

    public static UeLoop deserializeUeLoop(JsonObject __json__) {
        return new UeLoop(__json__);
    }

    public final int numLoops;
    public final boolean infiniteLoop;
    public final float infiniteLoopTimeoutTime;

    public static final int __ID__ = -513308166;

    @Override
    public int getTypeId() { return __ID__; }

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
        + "numLoops:" + numLoops + ","
        + "infiniteLoop:" + infiniteLoop + ","
        + "infiniteLoopTimeoutTime:" + infiniteLoopTimeoutTime + ","
        + "}";
    }
}
