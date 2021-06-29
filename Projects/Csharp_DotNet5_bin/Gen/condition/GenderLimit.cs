
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
   
public sealed partial class GenderLimit :  condition.BoolRoleCondition 
{
    public GenderLimit(ByteBuf _buf)  : base(_buf) 
    {
        Gender = (role.EGenderType)_buf.ReadInt();
    }

    public GenderLimit(role.EGenderType gender )  : base() 
    {
        this.Gender = gender;
    }

    public static GenderLimit DeserializeGenderLimit(ByteBuf _buf)
    {
        return new condition.GenderLimit(_buf);
    }

    public readonly role.EGenderType Gender;

    public const int ID = 103675143;
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
        + "Gender:" + Gender + ","
        + "}";
    }
    }

}

