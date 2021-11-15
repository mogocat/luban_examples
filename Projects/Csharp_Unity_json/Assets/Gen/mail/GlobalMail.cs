
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



namespace cfg.mail
{

public sealed class GlobalMail :  Bright.Config.BeanBase 
{
    public GlobalMail(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["title"].IsString) { throw new SerializationException(); }  Title = _json["title"]; }
        { if(!_json["sender"].IsString) { throw new SerializationException(); }  Sender = _json["sender"]; }
        { if(!_json["content"].IsString) { throw new SerializationException(); }  Content = _json["content"]; }
        { var _json1 = _json["award"]; if(!_json1.IsArray) { throw new SerializationException(); } Award = new System.Collections.Generic.List<int>(_json1.Count); foreach(JSONNode __e in _json1.Children) { int __v;  { if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e; }  Award.Add(__v); }   }
        { if(!_json["all_server"].IsBoolean) { throw new SerializationException(); }  AllServer = _json["all_server"]; }
        { var _json1 = _json["server_list"]; if(!_json1.IsArray) { throw new SerializationException(); } ServerList = new System.Collections.Generic.List<int>(_json1.Count); foreach(JSONNode __e in _json1.Children) { int __v;  { if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e; }  ServerList.Add(__v); }   }
        { if(!_json["platform"].IsString) { throw new SerializationException(); }  Platform = _json["platform"]; }
        { if(!_json["channel"].IsString) { throw new SerializationException(); }  Channel = _json["channel"]; }
        { if(!_json["min_max_level"].IsObject) { throw new SerializationException(); }  MinMaxLevel = condition.MinMaxLevel.DeserializeMinMaxLevel(_json["min_max_level"]); }
        { if(!_json["register_time"].IsObject) { throw new SerializationException(); }  RegisterTime = condition.TimeRange.DeserializeTimeRange(_json["register_time"]); }
        { if(!_json["mail_time"].IsObject) { throw new SerializationException(); }  MailTime = condition.TimeRange.DeserializeTimeRange(_json["mail_time"]); }
    }

    public GlobalMail(int id, string title, string sender, string content, System.Collections.Generic.List<int> award, bool all_server, System.Collections.Generic.List<int> server_list, string platform, string channel, condition.MinMaxLevel min_max_level, condition.TimeRange register_time, condition.TimeRange mail_time ) 
    {
        this.Id = id;
        this.Title = title;
        this.Sender = sender;
        this.Content = content;
        this.Award = award;
        this.AllServer = all_server;
        this.ServerList = server_list;
        this.Platform = platform;
        this.Channel = channel;
        this.MinMaxLevel = min_max_level;
        this.RegisterTime = register_time;
        this.MailTime = mail_time;
    }

    public static GlobalMail DeserializeGlobalMail(JSONNode _json)
    {
        return new mail.GlobalMail(_json);
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Sender { get; private set; }
    public string Content { get; private set; }
    public System.Collections.Generic.List<int> Award { get; private set; }
    public bool AllServer { get; private set; }
    public System.Collections.Generic.List<int> ServerList { get; private set; }
    public string Platform { get; private set; }
    public string Channel { get; private set; }
    public condition.MinMaxLevel MinMaxLevel { get; private set; }
    public condition.TimeRange RegisterTime { get; private set; }
    public condition.TimeRange MailTime { get; private set; }

    public const int ID = -287571791;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        MinMaxLevel?.Resolve(_tables);
        RegisterTime?.Resolve(_tables);
        MailTime?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        MinMaxLevel?.TranslateText(translator);
        RegisterTime?.TranslateText(translator);
        MailTime?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Title:" + Title + ","
        + "Sender:" + Sender + ","
        + "Content:" + Content + ","
        + "Award:" + Bright.Common.StringUtil.CollectionToString(Award) + ","
        + "AllServer:" + AllServer + ","
        + "ServerList:" + Bright.Common.StringUtil.CollectionToString(ServerList) + ","
        + "Platform:" + Platform + ","
        + "Channel:" + Channel + ","
        + "MinMaxLevel:" + MinMaxLevel + ","
        + "RegisterTime:" + RegisterTime + ","
        + "MailTime:" + MailTime + ","
        + "}";
    }
    }
}
