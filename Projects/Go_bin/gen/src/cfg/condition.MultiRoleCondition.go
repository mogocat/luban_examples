
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Condition_MultiRoleCondition struct {
    Condition_RoleCondition
    Conditions []interface{}
}


func (Condition_MultiRoleCondition) GetTypeId() int {
    return 934079583
}


func NewCondition_MultiRoleCondition(_buf *serialization.ByteBuf) (_v *Condition_MultiRoleCondition, err error) {
    _v = &Condition_MultiRoleCondition{}

    var _p *Condition_RoleCondition
     if _p, err = NewCondition_RoleCondition(_buf) ; err != nil { return }
    _v.Condition_RoleCondition = *_p

    if _v.Conditions, err = func (_buf2 *serialization.ByteBuf) (_v2 []interface{}, err2 error) {
                _v2 = make([]interface{}, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 interface{}
                    if v3, err2 = NewChildCondition_RoleCondition(_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

