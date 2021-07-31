
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



namespace cfg.l10n
{

/// <summary>
/// 
/// </summary>
public sealed partial class L10NDemo :  Bright.Config.BeanBase 
{
    public L10NDemo(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["text"].IsString) { throw new SerializationException(); }  Text = _json["text"]; }
    }

    public L10NDemo(int id, string text ) 
    {
        this.Id = id;
        this.Text = text;
    }

    public static L10NDemo DeserializeL10NDemo(JSONNode _json)
    {
        return new l10n.L10NDemo(_json);
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
