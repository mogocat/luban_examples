
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Condition_BoolRoleCondition struct {
    Condition_RoleCondition
}


func NewCondition_BoolRoleCondition(_buf *serialization.ByteBuf) (_v *Condition_BoolRoleCondition, err error) {
    _v = &Condition_BoolRoleCondition{}
    var _p *Condition_RoleCondition
     if _p, err = NewCondition_RoleCondition(_buf) ; err != nil { return }
    _v.Condition_RoleCondition = *_p
    return
}
func NewChildCondition_BoolRoleCondition(_buf *serialization.ByteBuf) (_v interface{}, err error) {
    var id int32
    if id, err = _buf.ReadInt() ; err != nil {
        return
    }
    switch id {
            case 103675143: return NewCondition_GenderLimit(_buf);
            case -1075273755: return NewCondition_MinLevel(_buf);
            case 700922899: return NewCondition_MaxLevel(_buf);
            case 907499647: return NewCondition_MinMaxLevel(_buf);
            case 696630835: return NewCondition_ClothesPropertyScoreGreaterThan(_buf);
    }
    return
}

