
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;


public final class TbCompositeJsonTable2 {
    private final java.util.HashMap<Integer, cfg.test.CompositeJsonTable2> _dataMap;
    private final java.util.ArrayList<cfg.test.CompositeJsonTable2> _dataList;
    
    public TbCompositeJsonTable2(JsonElement __json__) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.CompositeJsonTable2>();
        _dataList = new java.util.ArrayList<cfg.test.CompositeJsonTable2>();
        
        for(com.google.gson.JsonElement _e_ : __json__.getAsJsonArray()) {
            cfg.test.CompositeJsonTable2 _v;
            _v = new cfg.test.CompositeJsonTable2(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.CompositeJsonTable2> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.CompositeJsonTable2> getDataList() { return _dataList; }

    public cfg.test.CompositeJsonTable2 get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.CompositeJsonTable2 v : _dataList) {
            v.resolve(_tables);
        }
    }

}