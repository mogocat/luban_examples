
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
   
public sealed partial class DesignDrawing :  item.ItemExtra 
{
    public DesignDrawing(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("learn_component_id"); LearnComponentId = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  LearnComponentId.Add(__v); }   }
    }

    public DesignDrawing(int id, System.Collections.Generic.List<int> learn_component_id )  : base(id) 
    {
        this.LearnComponentId = learn_component_id;
    }

    public static DesignDrawing DeserializeDesignDrawing(JsonElement _buf)
    {
    
        return new item.DesignDrawing(_buf);
    
    }

     public readonly System.Collections.Generic.List<int> LearnComponentId;


    public const int ID = -1679179579;
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
        + "LearnComponentId:" + Bright.Common.StringUtil.CollectionToString(LearnComponentId) + ","
        + "}";
    }
    }
}

