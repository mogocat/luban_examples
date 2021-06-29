
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{
   
public sealed partial class Blackboard :  Bright.Config.BeanBase 
{
    public Blackboard(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        ParentName = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Keys = new System.Collections.Generic.List<ai.BlackboardKey>(n);for(var i = 0 ; i < n ; i++) { ai.BlackboardKey _e;  _e = ai.BlackboardKey.DeserializeBlackboardKey(_buf); Keys.Add(_e);}}
    }

    public Blackboard(string name, string desc, string parent_name, System.Collections.Generic.List<ai.BlackboardKey> keys ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.ParentName = parent_name;
        this.Keys = keys;
    }

    public static Blackboard DeserializeBlackboard(ByteBuf _buf)
    {
        return new ai.Blackboard(_buf);
    }

    public readonly string Name;
    public readonly string Desc;
    public readonly string ParentName;
    public ai.Blackboard ParentName_Ref;
    public readonly System.Collections.Generic.List<ai.BlackboardKey> Keys;

    public const int ID = 1576193005;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ParentName_Ref = (_tables["ai.TbBlackboard"] as ai.TbBlackboard).GetOrDefault(ParentName);
        foreach(var _e in Keys) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "ParentName:" + ParentName + ","
        + "Keys:" + Bright.Common.StringUtil.CollectionToString(Keys) + ","
        + "}";
    }
    }

}

