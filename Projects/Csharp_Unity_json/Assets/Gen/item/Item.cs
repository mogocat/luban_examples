
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.item
{

/// <summary>
/// 道具
/// </summary>
public sealed class Item :  Bright.Config.BeanBase 
{
    public Item(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["major_type"].IsNumber) { throw new SerializationException(); }  MajorType = (item.EMajorType)_json["major_type"].AsInt; }
        { if(!_json["minor_type"].IsNumber) { throw new SerializationException(); }  MinorType = (item.EMinorType)_json["minor_type"].AsInt; }
        { if(!_json["max_pile_num"].IsNumber) { throw new SerializationException(); }  MaxPileNum = _json["max_pile_num"]; }
        { if(!_json["quality"].IsNumber) { throw new SerializationException(); }  Quality = (item.EItemQuality)_json["quality"].AsInt; }
        { if(!_json["icon"].IsString) { throw new SerializationException(); }  Icon = _json["icon"]; }
        { if(!_json["icon_backgroud"].IsString) { throw new SerializationException(); }  IconBackgroud = _json["icon_backgroud"]; }
        { if(!_json["icon_mask"].IsString) { throw new SerializationException(); }  IconMask = _json["icon_mask"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["show_order"].IsNumber) { throw new SerializationException(); }  ShowOrder = _json["show_order"]; }
        { if(!_json["quantifier"].IsString) { throw new SerializationException(); }  Quantifier = _json["quantifier"]; }
        { if(!_json["show_in_bag"].IsBoolean) { throw new SerializationException(); }  ShowInBag = _json["show_in_bag"]; }
        { if(!_json["min_show_level"].IsNumber) { throw new SerializationException(); }  MinShowLevel = _json["min_show_level"]; }
        { if(!_json["batch_usable"].IsBoolean) { throw new SerializationException(); }  BatchUsable = _json["batch_usable"]; }
        { if(!_json["progress_time_when_use"].IsNumber) { throw new SerializationException(); }  ProgressTimeWhenUse = _json["progress_time_when_use"]; }
        { if(!_json["show_hint_when_use"].IsBoolean) { throw new SerializationException(); }  ShowHintWhenUse = _json["show_hint_when_use"]; }
        { if(!_json["droppable"].IsBoolean) { throw new SerializationException(); }  Droppable = _json["droppable"]; }
        { var _j = _json["price"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  Price = _j; } } else { Price = null; } }
        { if(!_json["use_type"].IsNumber) { throw new SerializationException(); }  UseType = (item.EUseType)_json["use_type"].AsInt; }
        { var _j = _json["level_up_id"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  LevelUpId = _j; } } else { LevelUpId = null; } }
    }

    public Item(int id, string name, item.EMajorType major_type, item.EMinorType minor_type, int max_pile_num, item.EItemQuality quality, string icon, string icon_backgroud, string icon_mask, string desc, int show_order, string quantifier, bool show_in_bag, int min_show_level, bool batch_usable, float progress_time_when_use, bool show_hint_when_use, bool droppable, int? price, item.EUseType use_type, int? level_up_id ) 
    {
        this.Id = id;
        this.Name = name;
        this.MajorType = major_type;
        this.MinorType = minor_type;
        this.MaxPileNum = max_pile_num;
        this.Quality = quality;
        this.Icon = icon;
        this.IconBackgroud = icon_backgroud;
        this.IconMask = icon_mask;
        this.Desc = desc;
        this.ShowOrder = show_order;
        this.Quantifier = quantifier;
        this.ShowInBag = show_in_bag;
        this.MinShowLevel = min_show_level;
        this.BatchUsable = batch_usable;
        this.ProgressTimeWhenUse = progress_time_when_use;
        this.ShowHintWhenUse = show_hint_when_use;
        this.Droppable = droppable;
        this.Price = price;
        this.UseType = use_type;
        this.LevelUpId = level_up_id;
    }

    public static Item DeserializeItem(JSONNode _json)
    {
        return new item.Item(_json);
    }

    /// <summary>
    /// 道具id
    /// </summary>
    public int Id { get; private set; }
    public string Name { get; private set; }
    public item.EMajorType MajorType { get; private set; }
    public item.EMinorType MinorType { get; private set; }
    public int MaxPileNum { get; private set; }
    public item.EItemQuality Quality { get; private set; }
    public string Icon { get; private set; }
    public string IconBackgroud { get; private set; }
    public string IconMask { get; private set; }
    public string Desc { get; private set; }
    public int ShowOrder { get; private set; }
    public string Quantifier { get; private set; }
    public bool ShowInBag { get; private set; }
    public int MinShowLevel { get; private set; }
    public bool BatchUsable { get; private set; }
    public float ProgressTimeWhenUse { get; private set; }
    public bool ShowHintWhenUse { get; private set; }
    public bool Droppable { get; private set; }
    public int? Price { get; private set; }
    public item.EUseType UseType { get; private set; }
    public int? LevelUpId { get; private set; }

    public const int ID = 2107285806;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "MajorType:" + MajorType + ","
        + "MinorType:" + MinorType + ","
        + "MaxPileNum:" + MaxPileNum + ","
        + "Quality:" + Quality + ","
        + "Icon:" + Icon + ","
        + "IconBackgroud:" + IconBackgroud + ","
        + "IconMask:" + IconMask + ","
        + "Desc:" + Desc + ","
        + "ShowOrder:" + ShowOrder + ","
        + "Quantifier:" + Quantifier + ","
        + "ShowInBag:" + ShowInBag + ","
        + "MinShowLevel:" + MinShowLevel + ","
        + "BatchUsable:" + BatchUsable + ","
        + "ProgressTimeWhenUse:" + ProgressTimeWhenUse + ","
        + "ShowHintWhenUse:" + ShowHintWhenUse + ","
        + "Droppable:" + Droppable + ","
        + "Price:" + Price + ","
        + "UseType:" + UseType + ","
        + "LevelUpId:" + LevelUpId + ","
        + "}";
    }
    }
}
