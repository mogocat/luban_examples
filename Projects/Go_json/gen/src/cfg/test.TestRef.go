
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_TestRef struct {
    Id int32
    X1 int32
    X2 int32
    A1 []int32
    A2 []int32
    B1 []int32
    B2 []int32
    C1 []int32
    C2 []int32
    D1 map[int32]int32
}

func (Test_TestRef) GetTypeId() int {
    return -543222491
}

func NewTest_TestRef(_buf map[string]interface{}) (_v *Test_TestRef, err error) {
    _v = &Test_TestRef{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x2"].(float64); !_ok_ { err = errors.New("x2 error"); return }; _v.X2 = int32(_tempNum_) }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["a1"].([]interface{}); !_ok_ { err = errors.New("a1 error"); return }

                _v.A1 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.A1 = append(_v.A1, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["a2"].([]interface{}); !_ok_ { err = errors.New("a2 error"); return }

                _v.A2 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.A2 = append(_v.A2, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["b1"].([]interface{}); !_ok_ { err = errors.New("b1 error"); return }

                _v.B1 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.B1 = append(_v.B1, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["b2"].([]interface{}); !_ok_ { err = errors.New("b2 error"); return }

                _v.B2 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.B2 = append(_v.B2, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["c1"].([]interface{}); !_ok_ { err = errors.New("c1 error"); return }

                _v.C1 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.C1 = append(_v.C1, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["c2"].([]interface{}); !_ok_ { err = errors.New("c2 error"); return }

                _v.C2 = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.C2 = append(_v.C2, _list_v_)
                }
            }

    {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["d1"].([]interface{}); !_ok_ { err = errors.New("d1 error"); return }

                _v.D1 = make(map[int32]int32)
                
                for _, _e_ := range _arr_ {
                    var _kv_ []interface{}
                    if _kv_, _ok_ = _e_.([]interface{}); !_ok_ || len(_kv_) != 2 { err = errors.New("d1 error"); return }
                    var _key_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[0].(float64); !_ok_ { err = errors.New("_key_ error"); return }; _key_ = int32(_x_) }
                    var _value_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _kv_[1].(float64); !_ok_ { err = errors.New("_value_ error"); return }; _value_ = int32(_x_) }
                    _v.D1[_key_] = _value_
                }
                }
    return
}