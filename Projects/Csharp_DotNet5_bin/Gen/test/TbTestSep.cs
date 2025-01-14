
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.test
{
   
public sealed class TbTestSep
{
    private readonly Dictionary<int, test.TestSep> _dataMap;
    private readonly List<test.TestSep> _dataList;
    
    public TbTestSep(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.TestSep>();
        _dataList = new List<test.TestSep>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.TestSep _v;
            _v = test.TestSep.DeserializeTestSep(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestSep> DataMap => _dataMap;
    public List<test.TestSep> DataList => _dataList;

    public test.TestSep GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestSep Get(int key) => _dataMap[key];
    public test.TestSep this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
}

}