
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{
   
public sealed partial class CoefficientItem :  bonus.Bonus 
{
    public CoefficientItem(ByteBuf _buf)  : base(_buf) 
    {
        BonusId = _buf.ReadInt();
        BonusList = bonus.Items.DeserializeItems(_buf);
    }

    public CoefficientItem(int bonus_id, bonus.Items bonus_list )  : base() 
    {
        this.BonusId = bonus_id;
        this.BonusList = bonus_list;
    }

    public static CoefficientItem DeserializeCoefficientItem(ByteBuf _buf)
    {
    
        return new bonus.CoefficientItem(_buf);
    
    }

    public readonly int BonusId;
    public readonly bonus.Items BonusList;


    public const int ID = -229470727;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
        BonusList?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "BonusId:" + BonusId + ","
        + "BonusList:" + BonusList + ","
        + "}";
    }
    }

}

