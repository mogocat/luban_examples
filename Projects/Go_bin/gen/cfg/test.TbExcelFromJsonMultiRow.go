
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type TestTbExcelFromJsonMultiRow struct {
    _dataMap map[int32]*TestExcelFromJsonMultiRow
    _dataList []*TestExcelFromJsonMultiRow
}

func NewTestTbExcelFromJsonMultiRow(_buf *serialization.ByteBuf) (*TestTbExcelFromJsonMultiRow, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestExcelFromJsonMultiRow, 0, size)
		dataMap := make(map[int32]*TestExcelFromJsonMultiRow)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestExcelFromJsonMultiRow(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &TestTbExcelFromJsonMultiRow{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *TestTbExcelFromJsonMultiRow) GetDataMap() map[int32]*TestExcelFromJsonMultiRow {
    return table._dataMap
}

func (table *TestTbExcelFromJsonMultiRow) GetDataList() []*TestExcelFromJsonMultiRow {
    return table._dataList
}

func (table *TestTbExcelFromJsonMultiRow) Get(key int32) *TestExcelFromJsonMultiRow {
    return table._dataMap[key]
}
