
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.mail
{

public sealed partial class SystemMail :  Bright.Config.BeanBase 
{
    public SystemMail(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Title = _buf.ReadString();
        Sender = _buf.ReadString();
        Content = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Award = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); Award.Add(_e);}}
    }

    public static SystemMail DeserializeSystemMail(ByteBuf _buf)
    {
        return new mail.SystemMail(_buf);
    }

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Sender { get; private set; }
    public string Content { get; private set; }
    public System.Collections.Generic.List<int> Award { get; private set; }

    public const int ID = 1214073149;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

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
