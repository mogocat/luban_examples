
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class WeightItems extends  cfg.bonus.Bonus 
{
    public WeightItems(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());itemList = new cfg.bonus.WeightItemInfo[n];for(var i = 0 ; i < n ; i++) { cfg.bonus.WeightItemInfo _e;_e = cfg.bonus.WeightItemInfo.deserializeWeightItemInfo(_buf); itemList[i] = _e;}}
    }

    public WeightItems(cfg.bonus.WeightItemInfo[] item_list )
    {
            super();
        this.itemList = item_list;
    }

    public static WeightItems deserializeWeightItems(ByteBuf _buf)
    {
    
        return new WeightItems(_buf);
    
    }

     public final cfg.bonus.WeightItemInfo[] itemList;


    public static final int ID = -356202311;

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
            for(cfg.bonus.WeightItemInfo _e : itemList) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString()
    {
        return "{ "
        + "itemList:" + itemList + ","
        + "}";
    }
}
