
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class DropBonus extends  cfg.bonus.Bonus 
{
    public DropBonus(ByteBuf _buf)
    { 
        super(_buf);
        id = _buf.readInt();
    }

    public DropBonus(int id )
    {
        super();
        this.id = id;
    }

    public static DropBonus deserializeDropBonus(ByteBuf _buf)
    {
        return new DropBonus(_buf);
    }

    public final int id;
    public cfg.bonus.DropInfo id_Ref;

    public static final int ID = 1959868225;

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
            this.id_Ref = ((cfg.bonus.TbDrop)_tables.get("bonus.TbDrop")).get(id);
    }

    @Override
    public String toString()
    {
        return "{ "
        + "id:" + id + ","
        + "}";
    }
}

