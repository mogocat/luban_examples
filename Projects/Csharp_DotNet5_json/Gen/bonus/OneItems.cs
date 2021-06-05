
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
   
public sealed partial class OneItems :  bonus.Bonus 
{
    public OneItems(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("items"); int _n = _json.GetArrayLength(); Items = new int[_n]; int _index=0; foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  Items[_index++] = __v; }   }
    }

    public OneItems(int[] items )  : base() 
    {
        this.Items = items;
    }

    public static OneItems DeserializeOneItems(JsonElement _buf)
    {
    
        return new bonus.OneItems(_buf);
    
    }

     public readonly int[] Items;


    public const int ID = 400179721;
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
        + "Items:" + Bright.Common.StringUtil.CollectionToString(Items) + ","
        + "}";
    }
    }
}

