
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestMultiRowRecord struct {
    Id int32
    Name string
    OneRows []*TestMultiRowType1
    MultiRows1 []*TestMultiRowType1
    MultiRows2 []*TestMultiRowType1
    MultiRows4 map[int32]*TestMultiRowType2
    MultiRows5 []*TestMultiRowType3
    MultiRows6 map[int32]*TestMultiRowType2
    MultiRows7 map[int32]int32
}

const TypeId_TestMultiRowRecord = -501249394

func (*TestMultiRowRecord) GetTypeId() int32 {
    return -501249394
}

func (_v *TestMultiRowRecord)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["one_rows"].([]interface{}); !_ok_ { err = errors.New("one_rows error"); return }

                _v.OneRows = make([]*TestMultiRowType1, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *TestMultiRowType1
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeTestMultiRowType1(_x_); err != nil { return } }
                    _v.OneRows = append(_v.OneRows, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows1"].([]interface{}); !_ok_ { err = errors.New("multi_rows1 error"); return }

                _v.MultiRows1 = make([]*TestMultiRowType1, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *TestMultiRowType1
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeTestMultiRowType1(_x_); err != nil { return } }
                    _v.MultiRows1 = append(_v.MultiRows1, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows2"].([]interface{}); !_ok_ { err = errors.New("multi_rows2 error"); return }

                _v.MultiRows2 = make([]*TestMultiRowType1, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *TestMultiRowType1
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeTestMultiRowType1(_x_); err != nil { return } }
                    _v.MultiRows2 = append(_v.MultiRows2, _list_v_)
                }
            }

    {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows4"].([]interface{}); !_ok_ { err = errors.New("multi_rows4 error"); return }

                _v.MultiRows4 = make(map[int32]*TestMultiRowType2)
                
                for _, _e_ := range _arr_ {
                    var _kv_ []interface{}
                    if _kv_, _ok_ = _e_.([]interface{}); !_ok_ || len(_kv_) != 2 { err = errors.New("multi_rows4 error"); return }
                    var _key_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[0].(float64); !_ok_ { err = errors.New("_key_ error"); return }; _key_ = int32(_x_) }
                    var _value_ *TestMultiRowType2
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _kv_[1].(map[string]interface{}); !_ok_ { err = errors.New("_value_ error"); return }; if _value_, err = DeserializeTestMultiRowType2(_x_); err != nil { return } }
                    _v.MultiRows4[_key_] = _value_
                }
                }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows5"].([]interface{}); !_ok_ { err = errors.New("multi_rows5 error"); return }

                _v.MultiRows5 = make([]*TestMultiRowType3, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *TestMultiRowType3
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeTestMultiRowType3(_x_); err != nil { return } }
                    _v.MultiRows5 = append(_v.MultiRows5, _list_v_)
                }
            }

    {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows6"].([]interface{}); !_ok_ { err = errors.New("multi_rows6 error"); return }

                _v.MultiRows6 = make(map[int32]*TestMultiRowType2)
                
                for _, _e_ := range _arr_ {
                    var _kv_ []interface{}
                    if _kv_, _ok_ = _e_.([]interface{}); !_ok_ || len(_kv_) != 2 { err = errors.New("multi_rows6 error"); return }
                    var _key_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[0].(float64); !_ok_ { err = errors.New("_key_ error"); return }; _key_ = int32(_x_) }
                    var _value_ *TestMultiRowType2
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _kv_[1].(map[string]interface{}); !_ok_ { err = errors.New("_value_ error"); return }; if _value_, err = DeserializeTestMultiRowType2(_x_); err != nil { return } }
                    _v.MultiRows6[_key_] = _value_
                }
                }
    {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["multi_rows7"].([]interface{}); !_ok_ { err = errors.New("multi_rows7 error"); return }

                _v.MultiRows7 = make(map[int32]int32)
                
                for _, _e_ := range _arr_ {
                    var _kv_ []interface{}
                    if _kv_, _ok_ = _e_.([]interface{}); !_ok_ || len(_kv_) != 2 { err = errors.New("multi_rows7 error"); return }
                    var _key_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[0].(float64); !_ok_ { err = errors.New("_key_ error"); return }; _key_ = int32(_x_) }
                    var _value_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[1].(float64); !_ok_ { err = errors.New("_value_ error"); return }; _value_ = int32(_x_) }
                    _v.MultiRows7[_key_] = _value_
                }
                }
    return
}

func DeserializeTestMultiRowRecord(_buf map[string]interface{}) (*TestMultiRowRecord, error) {
    v := &TestMultiRowRecord{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}