
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Limit_WeeklyLimit struct {
    Limit_LimitBase
    Num int32
}

func (Limit_WeeklyLimit) GetTypeId() int {
    return -252187161
}

func NewLimit_WeeklyLimit(_buf map[string]interface{}) (_v *Limit_WeeklyLimit, err error) {
    _v = &Limit_WeeklyLimit{}
    var _p *Limit_LimitBase
     if _p, err = NewLimit_LimitBase(_buf) ; err != nil { return }
    _v.Limit_LimitBase = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    return
}
