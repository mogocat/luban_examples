
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbExcelFromJsonMultiRow struct {
    _dataMap map[int32]*Test_ExcelFromJsonMultiRow
    _dataList []*Test_ExcelFromJsonMultiRow
}

func NewTest_TbExcelFromJsonMultiRow(_buf []map[string]interface{}) (*Test_TbExcelFromJsonMultiRow, error) {
	_dataList := make([]*Test_ExcelFromJsonMultiRow, 0, len(_buf))
	dataMap := make(map[int32]*Test_ExcelFromJsonMultiRow)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_ExcelFromJsonMultiRow(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Test_TbExcelFromJsonMultiRow{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbExcelFromJsonMultiRow) GetDataMap() map[int32]*Test_ExcelFromJsonMultiRow {
    return table._dataMap
}

func (table *Test_TbExcelFromJsonMultiRow) GetDataList() []*Test_ExcelFromJsonMultiRow {
    return table._dataList
}

func (table *Test_TbExcelFromJsonMultiRow) Get(key int32) *Test_ExcelFromJsonMultiRow {
    return table._dataMap[key]
}

