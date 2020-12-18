
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
   
public abstract partial class Bonus :  Bright.Config.BeanBase 
{
    public Bonus(JsonElement _buf) 
    {
    }

    public Bonus() 
    {
    }

    public static Bonus DeserializeBonus(JsonElement _buf)
    {
    
        if (_buf.ValueKind == JsonValueKind.Null) { return null; }
        switch (_buf.GetProperty("__type__").GetString())
        {
            case "OneItem": return new bonus.OneItem(_buf);
            case "OneItems": return new bonus.OneItems(_buf);
            case "Item": return new bonus.Item(_buf);
            case "Items": return new bonus.Items(_buf);
            case "CoefficientItem": return new bonus.CoefficientItem(_buf);
            case "WeightItems": return new bonus.WeightItems(_buf);
            case "ProbabilityItems": return new bonus.ProbabilityItems(_buf);
            case "MultiBonus": return new bonus.MultiBonus(_buf);
            case "ProbabilityBonus": return new bonus.ProbabilityBonus(_buf);
            case "WeightBonus": return new bonus.WeightBonus(_buf);
            case "DropBonus": return new bonus.DropBonus(_buf);
            default: throw new SerializationException();
        }
    
    }




    public virtual void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }
}

