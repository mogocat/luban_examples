
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
   
public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation(ByteBuf _buf)  : base(_buf) 
    {
        Location = _buf.ReadVector3();
        AcceptableRadius = _buf.ReadFloat();
    }

    public MoveToLocation(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, bool ignore_restart_self, System.Numerics.Vector3 location, float acceptable_radius )  : base(id,node_name,decorators,services,ignore_restart_self) 
    {
        this.Location = location;
        this.AcceptableRadius = acceptable_radius;
    }

    public static MoveToLocation DeserializeMoveToLocation(ByteBuf _buf)
    {
    
        return new ai.MoveToLocation(_buf);
    
    }

     public readonly System.Numerics.Vector3 Location;
     public readonly float AcceptableRadius;


    public const int ID = -969953113;
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
        + "Decorators:" + Decorators + ","
        + "Services:" + Services + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "Location:" + Location + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    }

}

