
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.l10n;

import bright.serialization.*;



public final class PatchDemo extends  bright.serialization.AbstractBean 
{
    public PatchDemo(ByteBuf _buf)
    { 
        id = _buf.readInt();
        value = _buf.readInt();
    }

    public PatchDemo(int id, int value )
    {
        this.id = id;
        this.value = value;
    }

    public static PatchDemo deserializePatchDemo(ByteBuf _buf)
    {
        return new PatchDemo(_buf);
    }

    public final int id;
    public final int value;

    public static final int ID = -1707294656;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
    }

    @Override
    public String toString()
    {
        return "{ "
        + "id:" + id + ","
        + "value:" + value + ","
        + "}";
    }
}
