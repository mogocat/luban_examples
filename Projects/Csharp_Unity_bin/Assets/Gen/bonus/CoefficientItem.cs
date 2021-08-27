
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

    public static CoefficientItem DeserializeCoefficientItem(ByteBuf _buf)
    {
        return new bonus.CoefficientItem(_buf);
    }

    public int BonusId { get; private set; }
    public bonus.Items BonusList { get; private set; }

    public const int ID = -229470727;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        BonusList?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        BonusList?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "BonusId:" + BonusId + ","
        + "BonusList:" + BonusList + ","
        + "}";
    }
    }

}
