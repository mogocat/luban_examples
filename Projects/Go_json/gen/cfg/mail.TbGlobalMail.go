
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type MailTbGlobalMail struct {
    _dataMap map[int32]*MailGlobalMail
    _dataList []*MailGlobalMail
}

func NewMailTbGlobalMail(_buf []map[string]interface{}) (*MailTbGlobalMail, error) {
	_dataList := make([]*MailGlobalMail, 0, len(_buf))
	dataMap := make(map[int32]*MailGlobalMail)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeMailGlobalMail(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &MailTbGlobalMail{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *MailTbGlobalMail) GetDataMap() map[int32]*MailGlobalMail {
    return table._dataMap
}

func (table *MailTbGlobalMail) GetDataList() []*MailGlobalMail {
    return table._dataList
}

func (table *MailTbGlobalMail) Get(key int32) *MailGlobalMail {
    return table._dataMap[key]
}


