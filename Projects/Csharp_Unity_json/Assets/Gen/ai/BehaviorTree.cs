
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



namespace cfg.ai
{

/// <summary>
/// 
/// </summary>
public sealed partial class BehaviorTree :  Bright.Config.BeanBase 
{
    public BehaviorTree(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["blackboard_id"].IsString) { throw new SerializationException(); }  BlackboardId = _json["blackboard_id"]; }
        { if(!_json["root"].IsObject) { throw new SerializationException(); }  Root = ai.ComposeNode.DeserializeComposeNode(_json["root"]); }
    }

    public BehaviorTree(int id, string name, string desc, string blackboard_id, ai.ComposeNode root ) 
    {
        this.Id = id;
        this.Name = name;
        this.Desc = desc;
        this.BlackboardId = blackboard_id;
        this.Root = root;
    }

    public static BehaviorTree DeserializeBehaviorTree(JSONNode _json)
    {
        return new ai.BehaviorTree(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Desc;
    /// <summary>
    /// 
    /// </summary>
    public readonly string BlackboardId;
    public ai.Blackboard BlackboardId_Ref;
    /// <summary>
    /// 
    /// </summary>
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
