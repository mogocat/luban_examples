
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type L10nTbPatchDemo struct {
    _dataMap map[int32]*L10nPatchDemo
    _dataList []*L10nPatchDemo
}

func NewL10nTbPatchDemo(_buf []map[string]interface{}) (*L10nTbPatchDemo, error) {
	_dataList := make([]*L10nPatchDemo, 0, len(_buf))
	dataMap := make(map[int32]*L10nPatchDemo)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeL10nPatchDemo(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &L10nTbPatchDemo{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *L10nTbPatchDemo) GetDataMap() map[int32]*L10nPatchDemo {
    return table._dataMap
}

func (table *L10nTbPatchDemo) GetDataList() []*L10nPatchDemo {
    return table._dataList
}

func (table *L10nTbPatchDemo) Get(key int32) *L10nPatchDemo {
    return table._dataMap[key]
}

