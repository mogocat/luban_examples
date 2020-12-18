
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



namespace cfg.blueprint
{
   
public sealed partial class Field :  Bright.Config.BeanBase 
{
    public Field(JsonElement _buf) 
    {
        Name = _buf.GetProperty("name").GetString();
        Type = _buf.GetProperty("type").GetString();
        Desc = _buf.GetProperty("desc").GetString();
    }

    public Field(string name, string type, string desc ) 
    {
        this.Name = name;
        this.Type = type;
        this.Desc = desc;
    }

    public static Field DeserializeField(JsonElement _buf)
    {
    
        return new blueprint.Field(_buf);
    
    }

     public readonly string Name;
     public readonly string Type;
     public readonly string Desc;


    public const int ID = 1694158271;
    public override int GetTypeId() => ID;


    public  void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    }
}

