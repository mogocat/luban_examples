
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TestTbTestNull struct {
    _dataMap map[int32]*TestTestNull
    _dataList []*TestTestNull
}

func NewTestTbTestNull(_buf []map[string]interface{}) (*TestTbTestNull, error) {
	_dataList := make([]*TestTestNull, 0, len(_buf))
	dataMap := make(map[int32]*TestTestNull)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTestTestNull(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &TestTbTestNull{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbTestNull) GetDataMap() map[int32]*TestTestNull {
    return table._dataMap
}

func (table *TestTbTestNull) GetDataList() []*TestTestNull {
    return table._dataList
}

func (table *TestTbTestNull) Get(key int32) *TestTestNull {
    return table._dataMap[key]
}

