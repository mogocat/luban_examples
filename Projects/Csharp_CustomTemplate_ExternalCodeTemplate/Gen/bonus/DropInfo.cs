
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



namespace cfg.bonus
{

public sealed class DropInfo :  Bright.Config.BeanBase 
{
    public DropInfo(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Desc = _json.GetProperty("desc").GetString();
        { var _json0 = _json.GetProperty("client_show_items"); ClientShowItems = new System.Collections.Generic.List<bonus.ShowItemInfo>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { bonus.ShowItemInfo __v;  __v =  bonus.ShowItemInfo.DeserializeShowItemInfo(__e);  ClientShowItems.Add(__v); }   }
        Bonus =  bonus.Bonus.DeserializeBonus(_json.GetProperty("bonus"));
    }

    public DropInfo(int id, string desc, System.Collections.Generic.List<bonus.ShowItemInfo> client_show_items, bonus.Bonus bonus ) 
    {
        this.Id = id;
        this.Desc = desc;
        this.ClientShowItems = client_show_items;
        this.Bonus = bonus;
    }

    public static DropInfo DeserializeDropInfo(JsonElement _json)
    {
        return new bonus.DropInfo(_json);
    }

    public int Id { get; private set; }
    public string Desc { get; private set; }
    public System.Collections.Generic.List<bonus.ShowItemInfo> ClientShowItems { get; private set; }
    public bonus.Bonus Bonus { get; private set; }

    public const int __ID__ = -2014781108;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in ClientShowItems) { _e?.Resolve(_tables); }
        Bonus?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in ClientShowItems) { _e?.TranslateText(translator); }
        Bonus?.TranslateText(translator);
    }

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