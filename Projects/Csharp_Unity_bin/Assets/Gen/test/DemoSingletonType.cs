
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class DemoSingletonType :  Bright.Config.BeanBase 
{
    public DemoSingletonType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name_l10n_key = _buf.ReadString(); Name = _buf.ReadString();
        Date = test.DemoDynamic.DeserializeDemoDynamic(_buf);
    }

    public static DemoSingletonType DeserializeDemoSingletonType(ByteBuf _buf)
    {
        return new test.DemoSingletonType(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Name_l10n_key { get; }
    public test.DemoDynamic Date { get; private set; }

    public const int ID = 539196998;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Date?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Name = translator(Name_l10n_key, Name);
        Date?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Date:" + Date + ","
        + "}";
    }
    }

}
