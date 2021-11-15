
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.common
{

public sealed class GlobalConfig :  Bright.Config.BeanBase 
{
    public GlobalConfig(ByteBuf _buf) 
    {
        BagCapacity = _buf.ReadInt();
        BagCapacitySpecial = _buf.ReadInt();
        BagTempExpendableCapacity = _buf.ReadInt();
        BagTempToolCapacity = _buf.ReadInt();
        BagInitCapacity = _buf.ReadInt();
        QuickBagCapacity = _buf.ReadInt();
        ClothBagCapacity = _buf.ReadInt();
        ClothBagInitCapacity = _buf.ReadInt();
        ClothBagCapacitySpecial = _buf.ReadInt();
        if(_buf.ReadBool()){ BagInitItemsDropId = _buf.ReadInt(); } else { BagInitItemsDropId = null; }
        MailBoxCapacity = _buf.ReadInt();
        DamageParamC = _buf.ReadFloat();
        DamageParamE = _buf.ReadFloat();
        DamageParamF = _buf.ReadFloat();
        DamageParamD = _buf.ReadFloat();
        RoleSpeed = _buf.ReadFloat();
        MonsterSpeed = _buf.ReadFloat();
        InitEnergy = _buf.ReadInt();
        InitViality = _buf.ReadInt();
        MaxViality = _buf.ReadInt();
        PerVialityRecoveryTime = _buf.ReadInt();
    }

    public static GlobalConfig DeserializeGlobalConfig(ByteBuf _buf)
    {
        return new common.GlobalConfig(_buf);
    }

    /// <summary>
    /// 背包容量
    /// </summary>
    public int BagCapacity { get; private set; }
    public int BagCapacitySpecial { get; private set; }
    public int BagTempExpendableCapacity { get; private set; }
    public int BagTempToolCapacity { get; private set; }
    public int BagInitCapacity { get; private set; }
    public int QuickBagCapacity { get; private set; }
    public int ClothBagCapacity { get; private set; }
    public int ClothBagInitCapacity { get; private set; }
    public int ClothBagCapacitySpecial { get; private set; }
    public int? BagInitItemsDropId { get; private set; }
    public bonus.DropInfo BagInitItemsDropId_Ref { get; private set; }
    public int MailBoxCapacity { get; private set; }
    public float DamageParamC { get; private set; }
    public float DamageParamE { get; private set; }
    public float DamageParamF { get; private set; }
    public float DamageParamD { get; private set; }
    public float RoleSpeed { get; private set; }
    public float MonsterSpeed { get; private set; }
    public int InitEnergy { get; private set; }
    public int InitViality { get; private set; }
    public int MaxViality { get; private set; }
    public int PerVialityRecoveryTime { get; private set; }

    public const int ID = -848234488;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.BagInitItemsDropId_Ref = this.BagInitItemsDropId != null ? (_tables["bonus.TbDrop"] as  bonus.TbDrop).GetOrDefault(BagInitItemsDropId.Value) : null;
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "BagCapacity:" + BagCapacity + ","
        + "BagCapacitySpecial:" + BagCapacitySpecial + ","
        + "BagTempExpendableCapacity:" + BagTempExpendableCapacity + ","
        + "BagTempToolCapacity:" + BagTempToolCapacity + ","
        + "BagInitCapacity:" + BagInitCapacity + ","
        + "QuickBagCapacity:" + QuickBagCapacity + ","
        + "ClothBagCapacity:" + ClothBagCapacity + ","
        + "ClothBagInitCapacity:" + ClothBagInitCapacity + ","
        + "ClothBagCapacitySpecial:" + ClothBagCapacitySpecial + ","
        + "BagInitItemsDropId:" + BagInitItemsDropId + ","
        + "MailBoxCapacity:" + MailBoxCapacity + ","
        + "DamageParamC:" + DamageParamC + ","
        + "DamageParamE:" + DamageParamE + ","
        + "DamageParamF:" + DamageParamF + ","
        + "DamageParamD:" + DamageParamD + ","
        + "RoleSpeed:" + RoleSpeed + ","
        + "MonsterSpeed:" + MonsterSpeed + ","
        + "InitEnergy:" + InitEnergy + ","
        + "InitViality:" + InitViality + ","
        + "MaxViality:" + MaxViality + ","
        + "PerVialityRecoveryTime:" + PerVialityRecoveryTime + ","
        + "}";
    }
    }

}
