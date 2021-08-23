
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

public sealed partial class SimpleParallel :  ai.ComposeNode 
{
    public SimpleParallel(JsonElement _json)  : base(_json) 
    {
        FinishMode = (ai.EFinishMode)_json.GetProperty("finish_mode").GetInt32();
        MainTask =  ai.Task.DeserializeTask(_json.GetProperty("main_task"));
        BackgroundNode =  ai.FlowNode.DeserializeFlowNode(_json.GetProperty("background_node"));
    }

    public SimpleParallel(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, ai.EFinishMode finish_mode, ai.Task main_task, ai.FlowNode background_node )  : base(id,node_name,decorators,services) 
    {
        this.FinishMode = finish_mode;
        this.MainTask = main_task;
        this.BackgroundNode = background_node;
    }

    public static SimpleParallel DeserializeSimpleParallel(JsonElement _json)
    {
        return new ai.SimpleParallel(_json);
    }

    public readonly ai.EFinishMode FinishMode;
    public readonly ai.Task MainTask;
    public readonly ai.FlowNode BackgroundNode;

    public const int ID = -1952582529;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        MainTask?.Resolve(_tables);
        BackgroundNode?.Resolve(_tables);
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
        + "FinishMode:" + FinishMode + ","
        + "MainTask:" + MainTask + ","
        + "BackgroundNode:" + BackgroundNode + ","
        + "}";
    }
    }
}

