
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.condition;

import bright.serialization.*;



public final class MultiRoleCondition extends  cfg.condition.RoleCondition 
{
    public MultiRoleCondition(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());conditions = new cfg.condition.RoleCondition[n];for(var i = 0 ; i < n ; i++) { cfg.condition.RoleCondition _e;_e = cfg.condition.RoleCondition.deserializeRoleCondition(_buf); conditions[i] = _e;}}
    }

    public MultiRoleCondition(cfg.condition.RoleCondition[] conditions )
    {
            super();
        this.conditions = conditions;
    }

    public static MultiRoleCondition deserializeMultiRoleCondition(ByteBuf _buf)
    {
    
        return new MultiRoleCondition(_buf);
    
    }

     public final cfg.condition.RoleCondition[] conditions;


    public static final int ID = 934079583;

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
            for(cfg.condition.RoleCondition _e : conditions) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString()
    {
        return "{ "
        + "conditions:" + conditions + ","
        + "}";
    }
}
