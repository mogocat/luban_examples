
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg


import "errors"

type Test_TbCompositeJsonTable3 struct {
    _data *Test_CompositeJsonTable3
}

func NewTest_TbCompositeJsonTable3(_buf []map[string]interface{}) (*Test_TbCompositeJsonTable3, error) {
	if len(_buf) != 1 {
        return nil, errors.New(" size != 1 ")
	} else {
		if _v, err2 := NewTest_CompositeJsonTable3(_buf[0]); err2 != nil {
			return nil, err2
		} else {
		    return &Test_TbCompositeJsonTable3{_data:_v}, nil
		}
	}
}

func (table *Test_TbCompositeJsonTable3) Get() *Test_CompositeJsonTable3 {
    return table._data
}

