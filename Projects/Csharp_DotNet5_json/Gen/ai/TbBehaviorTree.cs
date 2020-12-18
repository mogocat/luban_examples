
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{
public sealed partial class TbBehaviorTree
{
    private readonly Dictionary<int, ai.BehaviorTree> _dataMap;
    private readonly List<ai.BehaviorTree> _dataList;
    
    public TbBehaviorTree(JsonElement _buf)
    {
        _dataMap = new Dictionary<int, ai.BehaviorTree>();
        _dataList = new List<ai.BehaviorTree>();
        
        foreach(JsonElement _row in _buf.EnumerateArray())
        {
            var _v = ai.BehaviorTree.DeserializeBehaviorTree(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, ai.BehaviorTree> DataMap => _dataMap;
    public List<ai.BehaviorTree> DataList => _dataList;

    public ai.BehaviorTree GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ai.BehaviorTree Get(int key) => _dataMap[key];
    public ai.BehaviorTree this[int key] => _dataMap[key];

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
