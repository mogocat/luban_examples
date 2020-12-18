
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;

import bright.serialization.*;



public final class ErrorInfo extends  bright.serialization.AbstractBean 
{
    public ErrorInfo(ByteBuf _buf)
    { 
        code = _buf.readString();
        desc = _buf.readString();
        style = cfg.error.ErrorStyle.deserializeErrorStyle(_buf);
    }

    public ErrorInfo(String code, String desc, cfg.error.ErrorStyle style )
    {
        this.code = code;
        this.desc = desc;
        this.style = style;
    }

    public static ErrorInfo deserializeErrorInfo(ByteBuf _buf)
    {
    
        return new ErrorInfo(_buf);
    
    }

     public final String code;
     public final String desc;
     public final cfg.error.ErrorStyle style;


    public static final int ID = 1389347408;

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

            if (style != null) {style.resolve(_tables);}
    }

    @Override
    public String toString()
    {
        return "{ "
        + "code:" + code + ","
        + "desc:" + desc + ","
        + "style:" + style + ","
        + "}";
    }
}
