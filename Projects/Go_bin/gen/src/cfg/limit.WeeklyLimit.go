
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Limit_WeeklyLimit struct {
    Limit_LimitBase
    Num int32
}

func (Limit_WeeklyLimit) GetTypeId() int {
    return -252187161
}

func NewLimit_WeeklyLimit(_buf *serialization.ByteBuf) (_v *Limit_WeeklyLimit, err error) {
    _v = &Limit_WeeklyLimit{}
    var _p *Limit_LimitBase
     if _p, err = NewLimit_LimitBase(_buf) ; err != nil { return }
    _v.Limit_LimitBase = *_p
    if _v.Num, err = _buf.ReadInt(); err != nil  { return } 
    return
}

