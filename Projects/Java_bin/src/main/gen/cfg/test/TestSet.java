
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class TestSet {
    public TestSet(ByteBuf _buf) { 
        id = _buf.readInt();
        {int n = Math.min(_buf.readSize(), _buf.size());x1 = new java.util.ArrayList<Integer>(n);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); x1.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x2 = new java.util.ArrayList<Long>(n);for(int i = 0 ; i < n ; i++) { Long _e;  _e = _buf.readLong(); x2.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x3 = new java.util.ArrayList<String>(n);for(int i = 0 ; i < n ; i++) { String _e;  _e = _buf.readString(); x3.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x4 = new java.util.ArrayList<cfg.test.DemoEnum>(n);for(int i = 0 ; i < n ; i++) { cfg.test.DemoEnum _e;  _e = cfg.test.DemoEnum.valueOf(_buf.readInt()); x4.add(_e);}}
    }

    public TestSet(int id, java.util.ArrayList<Integer> x1, java.util.ArrayList<Long> x2, java.util.ArrayList<String> x3, java.util.ArrayList<cfg.test.DemoEnum> x4 ) {
        this.id = id;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }


    public final int id;
    public final java.util.ArrayList<Integer> x1;
    public final java.util.ArrayList<Long> x2;
    public final java.util.ArrayList<String> x3;
    public final java.util.ArrayList<cfg.test.DemoEnum> x4;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "x1:" + x1 + ","
        + "x2:" + x2 + ","
        + "x3:" + x3 + ","
        + "x4:" + x4 + ","
        + "}";
    }
}
