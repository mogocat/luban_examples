
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"

type Test_TbDemoPrimitive struct {
    _dataMap map[int32]*Test_DemoPrimitiveTypesTable
    _dataList []*Test_DemoPrimitiveTypesTable
}

func NewTest_TbDemoPrimitive(_buf *serialization.ByteBuf) (*Test_TbDemoPrimitive, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*Test_DemoPrimitiveTypesTable, 0, size)
		dataMap := make(map[int32]*Test_DemoPrimitiveTypesTable)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := NewTest_DemoPrimitiveTypesTable (_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.X4] = _v
			}
		}
		return &Test_TbDemoPrimitive{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *Test_TbDemoPrimitive) GetDataMap() map[int32]*Test_DemoPrimitiveTypesTable {
    return table._dataMap
}

func (table *Test_TbDemoPrimitive) GetDataList() []*Test_DemoPrimitiveTypesTable {
    return table._dataList
}

func (table *Test_TbDemoPrimitive) Get(key int32) *Test_DemoPrimitiveTypesTable {
    return table._dataMap[key]
}


