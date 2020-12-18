
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
   
public sealed partial class Items :  bonus.Bonus 
{
    public Items(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("item_list"); int _n = _json.GetArrayLength(); ItemList = new bonus.Item[_n]; int _index=0; foreach(JsonElement __e in _json.EnumerateArray()) { bonus.Item __v;  __v =  bonus.Item.DeserializeItem(__e);  ItemList[_index++] = __v; }   }
    }

    public Items(bonus.Item[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static Items DeserializeItems(JsonElement _buf)
    {
    
        return new bonus.Items(_buf);
    
    }

     public readonly bonus.Item[] ItemList;


    public const int ID = 819736849;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            foreach(var _e in ItemList) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + ItemList + ","
        + "}";
    }
    }
}

