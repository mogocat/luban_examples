
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"

type Test_TbTestExcelBean struct {
    _dataMap map[int32]*Test_TestExcelBean1
    _dataList []*Test_TestExcelBean1
}

func NewTest_TbTestExcelBean(_buf *serialization.ByteBuf) (*Test_TbTestExcelBean, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*Test_TestExcelBean1, 0, size)
		dataMap := make(map[int32]*Test_TestExcelBean1)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := NewTest_TestExcelBean1(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.X1] = _v
			}
		}
		return &Test_TbTestExcelBean{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *Test_TbTestExcelBean) GetDataMap() map[int32]*Test_TestExcelBean1 {
    return table._dataMap
}

func (table *Test_TbTestExcelBean) GetDataList() []*Test_TestExcelBean1 {
    return table._dataList
}

func (table *Test_TbTestExcelBean) Get(key int32) *Test_TestExcelBean1 {
    return table._dataMap[key]
}

