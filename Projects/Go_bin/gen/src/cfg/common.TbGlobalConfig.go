
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



import "errors"

type Common_TbGlobalConfig struct {
    _data *Common_GlobalConfig
}

func NewCommon_TbGlobalConfig(_buf *serialization.ByteBuf) (*Common_TbGlobalConfig, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
    } else if size != 1 {
        return nil, errors.New(" size != 1 ")
	} else {
		if _v, err2 := NewCommon_GlobalConfig (_buf); err2 != nil {
			return nil, err2
		} else {
		    return &Common_TbGlobalConfig{_data:_v}, nil
		}
	}
}

func (table *Common_TbGlobalConfig) Get() *Common_GlobalConfig {
    return table._data
}

