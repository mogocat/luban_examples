
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type TestTbNotIndexList struct {
    _dataList []*TestNotIndexList
}

func NewTestTbNotIndexList(_buf []map[string]interface{}) (*TestTbNotIndexList, error) {
	_dataList := make([]*TestNotIndexList, 0, len(_buf))
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeTestNotIndexList(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
		}
	}
	return &TestTbNotIndexList{_dataList:_dataList}, nil
}

func (table *TestTbNotIndexList) GetDataList() []*TestNotIndexList {
    return table._dataList
}

func (table *TestTbNotIndexList) Get(index int) *TestNotIndexList {
    return table._dataList[index]
}

