
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Limit_MonthlyLimit struct {
    Limit_LimitBase
    Num int32
}

func (Limit_MonthlyLimit) GetTypeId() int {
    return 2063279905
}

func NewLimit_MonthlyLimit(_buf map[string]interface{}) (_v *Limit_MonthlyLimit, err error) {
    _v = &Limit_MonthlyLimit{}
    var _p *Limit_LimitBase
     if _p, err = NewLimit_LimitBase(_buf) ; err != nil { return }
    _v.Limit_LimitBase = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    return
}
