
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"


type Bonus_TbDrop struct {
    _dataMap map[int32]*Bonus_DropInfo
    _dataList []*Bonus_DropInfo
}

func NewBonus_TbDrop(_buf *serialization.ByteBuf) (*Bonus_TbDrop, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*Bonus_DropInfo, 0, size)
		dataMap := make(map[int32]*Bonus_DropInfo)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := NewBonus_DropInfo (_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &Bonus_TbDrop{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *Bonus_TbDrop) GetDataMap() map[int32]*Bonus_DropInfo {
    return table._dataMap
}

func (table *Bonus_TbDrop) GetDataList() []*Bonus_DropInfo {
    return table._dataList
}

func (table *Bonus_TbDrop) Get(key int32) *Bonus_DropInfo {
    return table._dataMap[key]
}


