
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_CompositeJsonTable3 struct {
    A int32
    B int32
}

func (Test_CompositeJsonTable3) GetTypeId() int {
    return 1566207896
}

func NewTest_CompositeJsonTable3(_buf map[string]interface{}) (_v *Test_CompositeJsonTable3, err error) {
    _v = &Test_CompositeJsonTable3{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["a"].(float64); !_ok_ { err = errors.New("a error"); return }; _v.A = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["b"].(float64); !_ok_ { err = errors.New("b error"); return }; _v.B = int32(_tempNum_) }
    return
}
