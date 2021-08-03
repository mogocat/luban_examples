
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
   
/// <summary>
/// 
/// </summary>
public sealed partial class TbGlobalConfig
{

     private readonly common.GlobalConfig _data;

    public TbGlobalConfig(ByteBuf _buf)
    {
        int n = _buf.ReadSize();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = common.GlobalConfig.DeserializeGlobalConfig(_buf);
    }


    /// <summary>
    /// 背包容量
    /// </summary>
     public int BagCapacity => _data.BagCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int BagCapacitySpecial => _data.BagCapacitySpecial;
    /// <summary>
    /// 
    /// </summary>
     public int BagTempExpendableCapacity => _data.BagTempExpendableCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int BagTempToolCapacity => _data.BagTempToolCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int BagInitCapacity => _data.BagInitCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int QuickBagCapacity => _data.QuickBagCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int ClothBagCapacity => _data.ClothBagCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int ClothBagInitCapacity => _data.ClothBagInitCapacity;
    /// <summary>
    /// 
    /// </summary>
     public int ClothBagCapacitySpecial => _data.ClothBagCapacitySpecial;
    /// <summary>
    /// 
    /// </summary>
     public int? BagInitItemsDropId => _data.BagInitItemsDropId;
        public bonus.DropInfo BagInitItemsDropId_Ref => _data.BagInitItemsDropId_Ref;
    /// <summary>
    /// 
    /// </summary>
     public int MailBoxCapacity => _data.MailBoxCapacity;
    /// <summary>
    /// 
    /// </summary>
     public float DamageParamC => _data.DamageParamC;
    /// <summary>
    /// 
    /// </summary>
     public float DamageParamE => _data.DamageParamE;
    /// <summary>
    /// 
    /// </summary>
     public float DamageParamF => _data.DamageParamF;
    /// <summary>
    /// 
    /// </summary>
     public float DamageParamD => _data.DamageParamD;
    /// <summary>
    /// 
    /// </summary>
     public float RoleSpeed => _data.RoleSpeed;
    /// <summary>
    /// 
    /// </summary>
     public float MonsterSpeed => _data.MonsterSpeed;
    /// <summary>
    /// 
    /// </summary>
     public int InitEnergy => _data.InitEnergy;
    /// <summary>
    /// 
    /// </summary>
     public int InitViality => _data.InitViality;
    /// <summary>
    /// 
    /// </summary>
     public int MaxViality => _data.MaxViality;
    /// <summary>
    /// 
    /// </summary>
     public int PerVialityRecoveryTime => _data.PerVialityRecoveryTime;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
