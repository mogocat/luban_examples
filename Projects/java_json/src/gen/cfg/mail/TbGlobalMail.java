
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.mail;

import com.google.gson.JsonElement;


public final class TbGlobalMail {
    private final java.util.HashMap<Integer, cfg.mail.GlobalMail> _dataMap;
    private final java.util.ArrayList<cfg.mail.GlobalMail> _dataList;
    
    public TbGlobalMail(JsonElement __json__) {
        _dataMap = new java.util.HashMap<Integer, cfg.mail.GlobalMail>();
        _dataList = new java.util.ArrayList<cfg.mail.GlobalMail>();
        
        for(com.google.gson.JsonElement _e_ : __json__.getAsJsonArray()) {
            cfg.mail.GlobalMail _v;
            _v = new cfg.mail.GlobalMail(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.mail.GlobalMail> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.mail.GlobalMail> getDataList() { return _dataList; }

    public cfg.mail.GlobalMail get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.mail.GlobalMail v : _dataList) {
            v.resolve(_tables);
        }
    }

}