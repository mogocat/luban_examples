
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"

type Tag_TbTestTag struct {
    _dataMap map[int32]*Tag_TestTag
    _dataList []*Tag_TestTag
}

func NewTag_TbTestTag(_buf *serialization.ByteBuf) (*Tag_TbTestTag, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*Tag_TestTag, 0, size)
		dataMap := make(map[int32]*Tag_TestTag)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := NewTag_TestTag (_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
				dataMap[_v.Id] = _v
			}
		}
		return &Tag_TbTestTag{_dataList:_dataList, _dataMap:dataMap}, nil
	}
}

func (table *Tag_TbTestTag) GetDataMap() map[int32]*Tag_TestTag {
    return table._dataMap
}

func (table *Tag_TbTestTag) GetDataList() []*Tag_TestTag {
    return table._dataList
}

func (table *Tag_TbTestTag) Get(key int32) *Tag_TestTag {
    return table._dataMap[key]
}


