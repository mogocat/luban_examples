
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.condition;

import bright.serialization.*;



public final class MaxLevel extends  cfg.condition.BoolRoleCondition 
{
    public MaxLevel(ByteBuf _buf)
    { 
        super(_buf);
        level = _buf.readInt();
    }

    public MaxLevel(int level )
    {
            super();
        this.level = level;
    }

    public static MaxLevel deserializeMaxLevel(ByteBuf _buf)
    {
    
        return new MaxLevel(_buf);
    
    }

     public final int level;


    public static final int ID = 700922899;

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
    }

    @Override
    public String toString()
    {
        return "{ "
        + "level:" + level + ","
        + "}";
    }
}
