
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.cost
{

/// <summary>
/// 
/// </summary>
public abstract partial class Cost :  Bright.Config.BeanBase 
{
    public Cost(ByteBuf _buf) 
    {
    }

    public Cost() 
    {
    }

    public static Cost DeserializeCost(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case cost.CostCurrency.ID: return new cost.CostCurrency(_buf);
            case cost.CostCurrencies.ID: return new cost.CostCurrencies(_buf);
            case cost.CostOneItem.ID: return new cost.CostOneItem(_buf);
            case cost.CostItem.ID: return new cost.CostItem(_buf);
            case cost.CostItems.ID: return new cost.CostItems(_buf);
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

