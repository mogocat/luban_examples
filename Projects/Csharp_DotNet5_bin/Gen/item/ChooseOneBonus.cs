
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed class ChooseOneBonus :  Bright.Config.BeanBase 
{
    public ChooseOneBonus(ByteBuf _buf) 
    {
        DropId = _buf.ReadInt();
        IsUnique = _buf.ReadBool();
    }

    public static ChooseOneBonus DeserializeChooseOneBonus(ByteBuf _buf)
    {
        return new item.ChooseOneBonus(_buf);
    }

    public int DropId { get; private set; }
    public bonus.DropInfo DropId_Ref { get; private set; }
    public bool IsUnique { get; private set; }

    public const int __ID__ = 228058347;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.DropId_Ref = (_tables["bonus.TbDrop"] as bonus.TbDrop).GetOrDefault(DropId);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "DropId:" + DropId + ","
        + "IsUnique:" + IsUnique + ","
        + "}";
    }
    }

}
