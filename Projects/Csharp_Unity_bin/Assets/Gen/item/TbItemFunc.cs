
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.item
{
   
public sealed partial class TbItemFunc
{
    private readonly Dictionary<item.EMinorType, item.ItemFunction> _dataMap;
    private readonly List<item.ItemFunction> _dataList;
    
    public TbItemFunc(ByteBuf _buf)
    {
        _dataMap = new Dictionary<item.EMinorType, item.ItemFunction>();
        _dataList = new List<item.ItemFunction>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            item.ItemFunction _v;
            _v = item.ItemFunction.DeserializeItemFunction(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.MinorType, _v);
        }
    }

    public Dictionary<item.EMinorType, item.ItemFunction> DataMap => _dataMap;
    public List<item.ItemFunction> DataList => _dataList;

    public item.ItemFunction GetOrDefault(item.EMinorType key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public item.ItemFunction Get(item.EMinorType key) => _dataMap[key];
    public item.ItemFunction this[item.EMinorType key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        OnResolveFinish(_tables);
    }



    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
