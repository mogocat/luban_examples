
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
   
public abstract partial class BoolRoleCondition :  condition.RoleCondition 
{
    public BoolRoleCondition(ByteBuf _buf)  : base(_buf) 
    {
    }

    public BoolRoleCondition()  : base() 
    {
    }

    public static BoolRoleCondition DeserializeBoolRoleCondition(ByteBuf _buf)
    {
    
        switch (_buf.ReadInt())
        {
            case 0 : return null;
            case condition.GenderLimit.ID: return new condition.GenderLimit(_buf);
            case condition.MinLevel.ID: return new condition.MinLevel(_buf);
            case condition.MaxLevel.ID: return new condition.MaxLevel(_buf);
            case condition.MinMaxLevel.ID: return new condition.MinMaxLevel(_buf);
            case condition.ClothesPropertyScoreGreaterThan.ID: return new condition.ClothesPropertyScoreGreaterThan(_buf);
            default: throw new SerializationException();
        }
    
    }




    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }

}
