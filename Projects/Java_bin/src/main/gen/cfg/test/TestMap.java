
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public final class TestMap {
    public TestMap(ByteBuf _buf) { 
        id = _buf.readInt();
        {int n = Math.min(_buf.readSize(), _buf.size());x1 = new java.util.HashMap<Integer, Integer>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { Integer _k;  _k = _buf.readInt(); Integer _v;  _v = _buf.readInt();     x1.put(_k, _v);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x2 = new java.util.HashMap<Long, Integer>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { Long _k;  _k = _buf.readLong(); Integer _v;  _v = _buf.readInt();     x2.put(_k, _v);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x3 = new java.util.HashMap<String, Integer>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { String _k;  _k = _buf.readString(); Integer _v;  _v = _buf.readInt();     x3.put(_k, _v);}}
        {int n = Math.min(_buf.readSize(), _buf.size());x4 = new java.util.HashMap<cfg.test.DemoEnum, Integer>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { cfg.test.DemoEnum _k;  _k = cfg.test.DemoEnum.valueOf(_buf.readInt()); Integer _v;  _v = _buf.readInt();     x4.put(_k, _v);}}
    }

    public TestMap(int id, java.util.HashMap<Integer, Integer> x1, java.util.HashMap<Long, Integer> x2, java.util.HashMap<String, Integer> x3, java.util.HashMap<cfg.test.DemoEnum, Integer> x4 ) {
        this.id = id;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }


    public final int id;
    public final java.util.HashMap<Integer, Integer> x1;
    public final java.util.HashMap<Long, Integer> x2;
    public final java.util.HashMap<String, Integer> x3;
    public final java.util.HashMap<cfg.test.DemoEnum, Integer> x4;


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