
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Condition_MultiRoleCondition struct {
    Condition_RoleCondition
    Conditions []interface{}
}

func (Condition_MultiRoleCondition) GetTypeId() int {
    return 934079583
}

func NewCondition_MultiRoleCondition(_buf map[string]interface{}) (_v *Condition_MultiRoleCondition, err error) {
    _v = &Condition_MultiRoleCondition{}
    var _p *Condition_RoleCondition
     if _p, err = NewCondition_RoleCondition(_buf) ; err != nil { return }
    _v.Condition_RoleCondition = *_p
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["conditions"].([]interface{}); !_ok_ { err = errors.New("conditions error"); return }

                _v.Conditions = make([]interface{}, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ interface{}
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = NewChildCondition_RoleCondition(_x_); err != nil { return } }
                    _v.Conditions = append(_v.Conditions, _list_v_)
                }
            }

    return
}
