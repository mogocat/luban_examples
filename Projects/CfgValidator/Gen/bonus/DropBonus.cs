
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



namespace cfg.bonus
{

public sealed class DropBonus :  bonus.Bonus 
{
    public DropBonus(JsonElement _json)  : base(_json) 
    {
        Id = _json.GetProperty("id").GetInt32();
    }

    public DropBonus(int id )  : base() 
    {
        this.Id = id;
    }

    public static DropBonus DeserializeDropBonus(JsonElement _json)
    {
        return new bonus.DropBonus(_json);
    }

    public int Id { get; private set; }
    public bonus.DropInfo Id_Ref { get; private set; }

    public const int ID = 1959868225;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.Id_Ref = (_tables["bonus.TbDrop"] as bonus.TbDrop).GetOrDefault(Id);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "}";
    }
    }
}