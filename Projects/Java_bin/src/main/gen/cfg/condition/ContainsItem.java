
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.condition;

import bright.serialization.*;



public final class ContainsItem extends  cfg.condition.RoleCondition 
{
    public ContainsItem(ByteBuf _buf)
    { 
        super(_buf);
        itemId = _buf.readInt();
        num = _buf.readInt();
        reverse = _buf.readBool();
    }

    public ContainsItem(int item_id, int num, boolean reverse )
    {
            super();
        this.itemId = item_id;
        this.num = num;
        this.reverse = reverse;
    }

    public static ContainsItem deserializeContainsItem(ByteBuf _buf)
    {
    
        return new ContainsItem(_buf);
    
    }

     public final int itemId;
        public cfg.item.Item itemId_Ref;
     public final int num;
     public final boolean reverse;


    public static final int ID = 1961145317;

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
            this.itemId_Ref = ((cfg.item.TbItem)_tables.get("item.TbItem")).get(itemId);
    }

    @Override
    public String toString()
    {
        return "{ "
        + "itemId:" + itemId + ","
        + "num:" + num + ","
        + "reverse:" + reverse + ","
        + "}";
    }
}
