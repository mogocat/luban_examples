
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_TestRow struct {
    X int32
    Y bool
    Z string
    A *Test_Test3
    B []int32
}

func (Test_TestRow) GetTypeId() int {
    return -543222164
}

func NewTest_TestRow(_buf map[string]interface{}) (_v *Test_TestRow, err error) {
    _v = &Test_TestRow{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _v.X = int32(_tempNum_) }
    { var _ok_ bool; if _v.Y, _ok_ = _buf["y"].(bool); !_ok_ { err = errors.New("y error"); return } }
    { var _ok_ bool; if _v.Z, _ok_ = _buf["z"].(string); !_ok_ { err = errors.New("z error"); return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["a"].(map[string]interface{}); !_ok_ { err = errors.New("a error"); return }; if _v.A, err = NewTest_Test3(_x_); err != nil { return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["b"].([]interface{}); !_ok_ { err = errors.New("b error"); return }

                _v.B = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.B = append(_v.B, _list_v_)
                }
            }

    return
}