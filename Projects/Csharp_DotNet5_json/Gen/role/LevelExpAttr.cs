
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



namespace cfg.role
{
   
public sealed partial class LevelExpAttr :  Bright.Config.BeanBase 
{
    public LevelExpAttr(JsonElement _buf) 
    {
        Level = _buf.GetProperty("level").GetInt32();
        NeedExp = _buf.GetProperty("need_exp").GetInt64();
        { var _json = _buf.GetProperty("clothes_attrs"); ClothesAttrs = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  ClothesAttrs.Add(__v); }   }
    }

    public LevelExpAttr(int level, long need_exp, System.Collections.Generic.List<int> clothes_attrs ) 
    {
        this.Level = level;
        this.NeedExp = need_exp;
        this.ClothesAttrs = clothes_attrs;
    }

    public static LevelExpAttr DeserializeLevelExpAttr(JsonElement _buf)
    {
    
        return new role.LevelExpAttr(_buf);
    
    }

     public readonly int Level;
     public readonly long NeedExp;
     public readonly System.Collections.Generic.List<int> ClothesAttrs;


    public const int ID = -1569837022;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Level:" + Level + ","
        + "NeedExp:" + NeedExp + ","
        + "ClothesAttrs:" + ClothesAttrs + ","
        + "}";
    }
    }
}
