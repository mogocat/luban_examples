
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;

import bright.serialization.*;



public final class ErrorStyleDlgOk extends  cfg.error.ErrorStyle 
{
    public ErrorStyleDlgOk(ByteBuf _buf)
    { 
        super(_buf);
        btnName = _buf.readString();
    }

    public ErrorStyleDlgOk(String btn_name )
    {
            super();
        this.btnName = btn_name;
    }

    public static ErrorStyleDlgOk deserializeErrorStyleDlgOk(ByteBuf _buf)
    {
    
        return new ErrorStyleDlgOk(_buf);
    
    }

     public final String btnName;


    public static final int ID = -2010134516;

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
super.resolve(_tables);
    }

    @Override
    public String toString()
    {
        return "{ "
        + "btnName:" + btnName + ","
        + "}";
    }
}
