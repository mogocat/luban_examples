
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Item_TbItemExtra struct {
    _dataMap map[int32]interface{}
    _dataList []interface{}
}

func NewItem_TbItemExtra(_buf []map[string]interface{}) (*Item_TbItemExtra, error) {
	_dataList := make([]interface{}, 0, len(_buf))
	dataMap := make(map[int32]interface{})
	for _, _ele_ := range _buf {
		if _v, err2 := NewChildItem_ItemExtra(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
            if __v, __is := _v.(*Item_TreasureBox) ; __is {
                dataMap[__v.Id] = _v
                continue
            }
            if __v, __is := _v.(*Item_InteractionItem) ; __is {
                dataMap[__v.Id] = _v
                continue
            }
            if __v, __is := _v.(*Item_Clothes) ; __is {
                dataMap[__v.Id] = _v
                continue
            }
            if __v, __is := _v.(*Item_DesignDrawing) ; __is {
                dataMap[__v.Id] = _v
                continue
            }
            if __v, __is := _v.(*Item_Dymmy) ; __is {
                dataMap[__v.Id] = _v
                continue
            }
		}
	}
	return &Item_TbItemExtra{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Item_TbItemExtra) GetDataMap() map[int32]interface{} {
    return table._dataMap
}

func (table *Item_TbItemExtra) GetDataList() []interface{} {
    return table._dataList
}

func (table *Item_TbItemExtra) Get(key int32) interface{} {
    return table._dataMap[key]
}

