
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class ErrorStyleDlgOkCancel extends cfg.error.ErrorStyle {
    public ErrorStyleDlgOkCancel(JsonObject __json__) { 
        super(__json__);
        btn1Name = __json__.get("btn1_name").getAsString();
        btn2Name = __json__.get("btn2_name").getAsString();
    }

    public ErrorStyleDlgOkCancel(String btn1_name, String btn2_name ) {
        super();
        this.btn1Name = btn1_name;
        this.btn2Name = btn2_name;
    }

    public static ErrorStyleDlgOkCancel deserializeErrorStyleDlgOkCancel(JsonObject __json__) {
        return new ErrorStyleDlgOkCancel(__json__);
    }

    public final String btn1Name;
    public final String btn2Name;

    public static final int __ID__ = 971221414;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "btn1Name:" + btn1Name + ","
        + "btn2Name:" + btn2Name + ","
        + "}";
    }
}
