
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
   
public sealed partial class DropInfo :  Bright.Config.BeanBase 
{
    public DropInfo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Desc = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ClientShowItems = new System.Collections.Generic.List<bonus.ShowItemInfo>(n);for(var i = 0 ; i < n ; i++) { bonus.ShowItemInfo _e;  _e = bonus.ShowItemInfo.DeserializeShowItemInfo(_buf); ClientShowItems.Add(_e);}}
        Bonus = bonus.Bonus.DeserializeBonus(_buf);
    }

    public DropInfo(int id, string desc, System.Collections.Generic.List<bonus.ShowItemInfo> client_show_items, bonus.Bonus bonus ) 
    {
        this.Id = id;
        this.Desc = desc;
        this.ClientShowItems = client_show_items;
        this.Bonus = bonus;
    }

    public static DropInfo DeserializeDropInfo(ByteBuf _buf)
    {
    
        return new bonus.DropInfo(_buf);
    
    }

    public readonly int Id;
    public readonly string Desc;
    public readonly System.Collections.Generic.List<bonus.ShowItemInfo> ClientShowItems;
    public readonly bonus.Bonus Bonus;


    public const int ID = -2014781108;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        foreach(var _e in ClientShowItems) { _e?.Resolve(_tables); }
        Bonus?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Desc:" + Desc + ","
        + "ClientShowItems:" + Bright.Common.StringUtil.CollectionToString(ClientShowItems) + ","
        + "Bonus:" + Bonus + ","
        + "}";
    }
    }

}

