
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import bright.serialization.*;



public final class TestString extends  bright.serialization.AbstractBean 
{
    public TestString(ByteBuf _buf)
    { 
        id = _buf.readInt();
        s1 = _buf.readString();
        cs1 = cfg.test.CompactString.deserializeCompactString(_buf);
        cs2 = cfg.test.CompactString.deserializeCompactString(_buf);
    }

    public TestString(int id, String s1, cfg.test.CompactString cs1, cfg.test.CompactString cs2 )
    {
        this.id = id;
        this.s1 = s1;
        this.cs1 = cs1;
        this.cs2 = cs2;
    }

    public static TestString deserializeTestString(ByteBuf _buf)
    {
        return new TestString(_buf);
    }

    public final int id;
    public final String s1;
    public final cfg.test.CompactString cs1;
    public final cfg.test.CompactString cs2;

    public static final int ID = 338485823;

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
            if (cs1 != null) {cs1.resolve(_tables);}
            if (cs2 != null) {cs2.resolve(_tables);}
    }

    @Override
    public String toString()
    {
        return "{ "
        + "id:" + id + ","
        + "s1:" + s1 + ","
        + "cs1:" + cs1 + ","
        + "cs2:" + cs2 + ","
        + "}";
    }
}
