
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import bright.serialization.*;



public final class ChooseTarget extends cfg.ai.Service {
    public ChooseTarget(ByteBuf _buf) { 
        super(_buf);
        resultTargetKey = _buf.readString();
    }

    public ChooseTarget(int id, String node_name, String result_target_key ) {
        super(id, node_name);
        this.resultTargetKey = result_target_key;
    }


    public final String resultTargetKey;

    public static final int __ID__ = 1601247918;

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
        + "resultTargetKey:" + resultTargetKey + ","
        + "}";
    }
}
