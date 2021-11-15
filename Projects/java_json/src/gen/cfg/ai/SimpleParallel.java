
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



public final class SimpleParallel extends cfg.ai.ComposeNode {
    public SimpleParallel(JsonObject __json__) { 
        super(__json__);
        finishMode = cfg.ai.EFinishMode.valueOf(__json__.get("finish_mode").getAsInt());
        mainTask = cfg.ai.Task.deserializeTask(__json__.get("main_task").getAsJsonObject());
        backgroundNode = cfg.ai.FlowNode.deserializeFlowNode(__json__.get("background_node").getAsJsonObject());
    }

    public SimpleParallel(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, cfg.ai.EFinishMode finish_mode, cfg.ai.Task main_task, cfg.ai.FlowNode background_node ) {
        super(id, node_name, decorators, services);
        this.finishMode = finish_mode;
        this.mainTask = main_task;
        this.backgroundNode = background_node;
    }

    public static SimpleParallel deserializeSimpleParallel(JsonObject __json__) {
        return new SimpleParallel(__json__);
    }

    public final cfg.ai.EFinishMode finishMode;
    public final cfg.ai.Task mainTask;
    public final cfg.ai.FlowNode backgroundNode;

    public static final int __ID__ = -1952582529;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        if (mainTask != null) {mainTask.resolve(_tables);}
        if (backgroundNode != null) {backgroundNode.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "finishMode:" + finishMode + ","
        + "mainTask:" + mainTask + ","
        + "backgroundNode:" + backgroundNode + ","
        + "}";
    }
}
