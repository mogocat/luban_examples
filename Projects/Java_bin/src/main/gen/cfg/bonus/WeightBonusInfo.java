
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.bonus;

import bright.serialization.*;



public final class WeightBonusInfo extends  bright.serialization.AbstractBean 
{
    public WeightBonusInfo(ByteBuf _buf)
    { 
        bonus = cfg.bonus.Bonus.deserializeBonus(_buf);
        weight = _buf.readInt();
    }

    public WeightBonusInfo(cfg.bonus.Bonus bonus, int weight )
    {
        this.bonus = bonus;
        this.weight = weight;
    }

    public static WeightBonusInfo deserializeWeightBonusInfo(ByteBuf _buf)
    {
    
        return new WeightBonusInfo(_buf);
    
    }

     public final cfg.bonus.Bonus bonus;
     public final int weight;


    public static final int ID = -907244058;

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

            if (bonus != null) {bonus.resolve(_tables);}
    }

    @Override
    public String toString()
    {
        return "{ "
        + "bonus:" + bonus + ","
        + "weight:" + weight + ","
        + "}";
    }
}
