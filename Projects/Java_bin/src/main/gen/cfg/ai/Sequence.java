
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import bright.serialization.*;



public final class Sequence extends  cfg.ai.ComposeNode 
{
    public Sequence(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());children = new java.util.ArrayList<cfg.ai.FlowNode>(n);for(var i = 0 ; i < n ; i++) { cfg.ai.FlowNode _e;  _e = cfg.ai.FlowNode.deserializeFlowNode(_buf); children.add(_e);}}
    }

    public Sequence(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, java.util.ArrayList<cfg.ai.FlowNode> children )
    {
        super(id, node_name, decorators, services);
        this.children = children;
    }

    public static Sequence deserializeSequence(ByteBuf _buf)
    {
        return new Sequence(_buf);
    }

    public final java.util.ArrayList<cfg.ai.FlowNode> children;

    public static final int ID = -1789006105;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        super.resolve(_tables);
            for(cfg.ai.FlowNode _e : children) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "children:" + children + ","
        + "}";
    }
}

