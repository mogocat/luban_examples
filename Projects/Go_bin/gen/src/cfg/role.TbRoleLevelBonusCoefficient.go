
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"

type Role_TbRoleLevelBonusCoefficient struct {
    _dataMap map[int32]*Role_LevelBonus
    _dataList []*Role_LevelBonus
}

func NewRole_TbRoleLevelBonusCoefficient(_buf *serialization.ByteBuf) (*Role_TbRoleLevelBonusCoefficient, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*Role_LevelBonus, 0, size)
		dataMap := make(map[int32]*Role_LevelBonus)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := NewRole_LevelBonus (_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &Role_TbRoleLevelBonusCoefficient{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *Role_TbRoleLevelBonusCoefficient) GetDataMap() map[int32]*Role_LevelBonus {
    return table._dataMap
}

func (table *Role_TbRoleLevelBonusCoefficient) GetDataList() []*Role_LevelBonus {
    return table._dataList
}

func (table *Role_TbRoleLevelBonusCoefficient) Get(key int32) *Role_LevelBonus {
    return table._dataMap[key]
}



