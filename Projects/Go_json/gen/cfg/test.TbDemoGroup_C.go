
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TestTbDemoGroup_C struct {
    _dataMap map[int32]*TestDemoGroup
    _dataList []*TestDemoGroup
}

func NewTestTbDemoGroup_C(_buf []map[string]interface{}) (*TestTbDemoGroup_C, error) {
	_dataList := make([]*TestDemoGroup, 0, len(_buf))
	dataMap := make(map[int32]*TestDemoGroup)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTestDemoGroup(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &TestTbDemoGroup_C{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbDemoGroup_C) GetDataMap() map[int32]*TestDemoGroup {
    return table._dataMap
}

func (table *TestTbDemoGroup_C) GetDataList() []*TestDemoGroup {
    return table._dataList
}

func (table *TestTbDemoGroup_C) Get(key int32) *TestDemoGroup {
    return table._dataMap[key]
}


