
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_DemoDynamic struct {
    X1 int32
}


func NewTest_DemoDynamic(_buf map[string]interface{}) (_v *Test_DemoDynamic, err error) {
    _v = &Test_DemoDynamic{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    return
}
func NewChildTest_DemoDynamic(_buf map[string]interface{}) (_v interface{}, err error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "DemoD2": return NewTest_DemoD2(_buf);
        case "DemoE1": return NewTest_DemoE1(_buf);
        case "DemoD5": return NewTest_DemoD5(_buf);
        default: return nil, errors.New("unknown type id")
    }
    return
}
