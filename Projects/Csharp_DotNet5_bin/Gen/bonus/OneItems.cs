
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{
   
public sealed partial class OneItems :  bonus.Bonus 
{
    public OneItems(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Items = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); Items[i] = _e;}}
    }

    public OneItems(int[] items )  : base() 
    {
        this.Items = items;
    }

    public static OneItems DeserializeOneItems(ByteBuf _buf)
    {
    
        return new bonus.OneItems(_buf);
    
    }

     public readonly int[] Items;


    public const int ID = 400179721;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Items:" + Items + ","
        + "}";
    }
    }

}
