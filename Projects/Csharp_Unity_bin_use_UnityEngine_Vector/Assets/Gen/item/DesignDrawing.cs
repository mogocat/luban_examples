
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

/// <summary>
/// 
/// </summary>
public sealed partial class DesignDrawing :  item.ItemExtra 
{
    public DesignDrawing(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);LearnComponentId = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); LearnComponentId.Add(_e);}}
    }

    public DesignDrawing(int id, System.Collections.Generic.List<int> learn_component_id )  : base(id) 
    {
        this.LearnComponentId = learn_component_id;
    }

    public static DesignDrawing DeserializeDesignDrawing(ByteBuf _buf)
    {
        return new item.DesignDrawing(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
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
