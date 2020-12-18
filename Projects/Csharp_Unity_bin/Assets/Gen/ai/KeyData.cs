
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{
   
public abstract partial class KeyData :  Bright.Config.BeanBase 
{
    public KeyData(ByteBuf _buf) 
    {
    }

    public KeyData() 
    {
    }

    public static KeyData DeserializeKeyData(ByteBuf _buf)
    {
    
        switch (_buf.ReadInt())
        {
            case 0 : return null;
            case ai.FloatKeyData.ID: return new ai.FloatKeyData(_buf);
            case ai.IntKeyData.ID: return new ai.IntKeyData(_buf);
            case ai.StringKeyData.ID: return new ai.StringKeyData(_buf);
            case ai.BlackboardKeyData.ID: return new ai.BlackboardKeyData(_buf);
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

