
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.role
{
   
public sealed partial class LevelBonus :  Bright.Config.BeanBase 
{
    public LevelBonus(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);DistinctBonusInfos = new System.Collections.Generic.List<role.DistinctBonusInfos>(n);for(var i = 0 ; i < n ; i++) { role.DistinctBonusInfos _e;  _e = role.DistinctBonusInfos.DeserializeDistinctBonusInfos(_buf); DistinctBonusInfos.Add(_e);}}
    }

    public LevelBonus(int id, System.Collections.Generic.List<role.DistinctBonusInfos> distinct_bonus_infos ) 
    {
        this.Id = id;
        this.DistinctBonusInfos = distinct_bonus_infos;
    }

    public static LevelBonus DeserializeLevelBonus(ByteBuf _buf)
    {
    
        return new role.LevelBonus(_buf);
    
    }

     public readonly int Id;
     public readonly System.Collections.Generic.List<role.DistinctBonusInfos> DistinctBonusInfos;


    public const int ID = -572269677;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

            foreach(var _e in DistinctBonusInfos) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "DistinctBonusInfos:" + Bright.Common.StringUtil.CollectionToString(DistinctBonusInfos) + ","
        + "}";
    }
    }

}

