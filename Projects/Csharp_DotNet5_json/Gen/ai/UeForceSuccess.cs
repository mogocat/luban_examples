
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
   
public sealed partial class UeForceSuccess :  ai.Decorator 
{
    public UeForceSuccess(JsonElement _buf)  : base(_buf) 
    {
    }

    public UeForceSuccess(int id, string node_name, ai.EFlowAbortMode flow_abort_mode )  : base(id,node_name,flow_abort_mode) 
    {
    }

    public static UeForceSuccess DeserializeUeForceSuccess(JsonElement _buf)
    {
    
        return new ai.UeForceSuccess(_buf);
    
    }



    public const int ID = 195054574;
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
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
    }
}
