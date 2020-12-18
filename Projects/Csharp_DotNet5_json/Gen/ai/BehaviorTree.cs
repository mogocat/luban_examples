
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



namespace cfg.ai
{
   
public sealed partial class BehaviorTree :  Bright.Config.BeanBase 
{
    public BehaviorTree(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Name = _buf.GetProperty("name").GetString();
        Desc = _buf.GetProperty("desc").GetString();
        BlackboardId = _buf.GetProperty("blackboard_id").GetString();
        { var _j = _buf.GetProperty("root"); if (_j.ValueKind != JsonValueKind.Null) { Root =  ai.ComposeNode.DeserializeComposeNode(_j); } else { Root = null; } }
    }

    public BehaviorTree(int id, string name, string desc, string blackboard_id, ai.ComposeNode root ) 
    {
        this.Id = id;
        this.Name = name;
        this.Desc = desc;
        this.BlackboardId = blackboard_id;
        this.Root = root;
    }

    public static BehaviorTree DeserializeBehaviorTree(JsonElement _buf)
    {
    
        return new ai.BehaviorTree(_buf);
    
    }

     public readonly int Id;
     public readonly string Name;
     public readonly string Desc;
     public readonly string BlackboardId;
        public ai.Blackboard BlackboardId_Ref;
     public readonly ai.ComposeNode Root;


    public const int ID = 159552822;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

            this.BlackboardId_Ref = (_tables["ai.TbBlackboard"] as ai.TbBlackboard).GetOrDefault(BlackboardId);
            Root?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "BlackboardId:" + BlackboardId + ","
        + "Root:" + Root + ","
        + "}";
    }
    }
}
