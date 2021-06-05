
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
   
public sealed partial class ChooseSkill :  ai.Task 
{
    public ChooseSkill(ByteBuf _buf)  : base(_buf) 
    {
        TargetActorKey = _buf.ReadString();
        ResultSkillIdKey = _buf.ReadString();
    }

    public ChooseSkill(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, string target_actor_key, string result_skill_id_key )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.TargetActorKey = target_actor_key;
        this.ResultSkillIdKey = result_skill_id_key;
    }

    public static ChooseSkill DeserializeChooseSkill(ByteBuf _buf)
    {
    
        return new ai.ChooseSkill(_buf);
    
    }

     public readonly string TargetActorKey;
     public readonly string ResultSkillIdKey;


    public const int ID = -918812268;
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
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "TargetActorKey:" + TargetActorKey + ","
        + "ResultSkillIdKey:" + ResultSkillIdKey + ","
        + "}";
    }
    }

}

