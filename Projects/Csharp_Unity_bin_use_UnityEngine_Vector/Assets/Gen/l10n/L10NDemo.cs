
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.l10n
{

/// <summary>
/// 
/// </summary>
public sealed partial class L10NDemo :  Bright.Config.BeanBase 
{
    public L10NDemo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Text = _buf.ReadString();
    }

    public L10NDemo(int id, string text ) 
    {
        this.Id = id;
        this.Text = text;
    }

    public static L10NDemo DeserializeL10NDemo(ByteBuf _buf)
    {
        return new l10n.L10NDemo(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Text;

    public const int ID = -331195887;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Text:" + Text + ","
        + "}";
    }
    }

}
