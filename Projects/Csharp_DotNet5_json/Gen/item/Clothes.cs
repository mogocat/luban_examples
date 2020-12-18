
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.item
{
   
public sealed partial class Clothes :  item.ItemExtra 
{
    public Clothes(JsonElement _buf)  : base(_buf) 
    {
        Attack = _buf.GetProperty("attack").GetInt32();
        Hp = _buf.GetProperty("hp").GetInt64();
        EnergyLimit = _buf.GetProperty("energy_limit").GetInt32();
        EnergyResume = _buf.GetProperty("energy_resume").GetInt32();
    }

    public Clothes(int id, int attack, long hp, int energy_limit, int energy_resume )  : base(id) 
    {
        this.Attack = attack;
        this.Hp = hp;
        this.EnergyLimit = energy_limit;
        this.EnergyResume = energy_resume;
    }

    public static Clothes DeserializeClothes(JsonElement _buf)
    {
    
        return new item.Clothes(_buf);
    
    }

     public readonly int Attack;
     public readonly long Hp;
     public readonly int EnergyLimit;
     public readonly int EnergyResume;


    public const int ID = 1659907149;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Attack:" + Attack + ","
        + "Hp:" + Hp + ","
        + "EnergyLimit:" + EnergyLimit + ","
        + "EnergyResume:" + EnergyResume + ","
        + "}";
    }
    }
}
