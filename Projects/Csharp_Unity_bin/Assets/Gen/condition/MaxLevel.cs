
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{
   
public sealed partial class MaxLevel :  condition.BoolRoleCondition 
{
    public MaxLevel(ByteBuf _buf)  : base(_buf) 
    {
        Level = _buf.ReadInt();
    }

    public MaxLevel(int level )  : base() 
    {
        this.Level = level;
    }

    public static MaxLevel DeserializeMaxLevel(ByteBuf _buf)
    {
    
        return new condition.MaxLevel(_buf);
    
    }

     public readonly int Level;


    public const int ID = 700922899;
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
        + "Level:" + Level + ","
        + "}";
    }
    }

}

