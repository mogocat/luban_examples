
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Condition_MaxLevel struct {
    Condition_BoolRoleCondition
    Level int32
}


func (Condition_MaxLevel) GetTypeId() int {
    return 700922899
}


func NewCondition_MaxLevel(_buf *serialization.ByteBuf) (_v *Condition_MaxLevel, err error) {
    _v = &Condition_MaxLevel{}

    var _p *Condition_BoolRoleCondition
     if _p, err = NewCondition_BoolRoleCondition(_buf) ; err != nil { return }
    _v.Condition_BoolRoleCondition = *_p

    if _v.Level, err = _buf.ReadInt(); err != nil  { return } 
    return
}

