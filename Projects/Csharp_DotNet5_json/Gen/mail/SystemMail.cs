
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



namespace cfg.mail
{
   
public sealed partial class SystemMail :  Bright.Config.BeanBase 
{
    public SystemMail(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        Title = _buf.GetProperty("title").GetString();
        Sender = _buf.GetProperty("sender").GetString();
        Content = _buf.GetProperty("content").GetString();
        { var _json = _buf.GetProperty("award"); Award = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  Award.Add(__v); }   }
    }

    public SystemMail(int id, string title, string sender, string content, System.Collections.Generic.List<int> award ) 
    {
        this.Id = id;
        this.Title = title;
        this.Sender = sender;
        this.Content = content;
        this.Award = award;
    }

    public static SystemMail DeserializeSystemMail(JsonElement _buf)
    {
    
        return new mail.SystemMail(_buf);
    
    }

     public readonly int Id;
     public readonly string Title;
     public readonly string Sender;
     public readonly string Content;
     public readonly System.Collections.Generic.List<int> Award;


    public const int ID = 1214073149;
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
        + "Title:" + Title + ","
        + "Sender:" + Sender + ","
        + "Content:" + Content + ","
        + "Award:" + Bright.Common.StringUtil.CollectionToString(Award) + ","
        + "}";
    }
    }
}

