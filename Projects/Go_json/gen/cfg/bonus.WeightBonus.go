
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BonusWeightBonus struct {
    Bonuses []*BonusWeightBonusInfo
}

const TypeId_BonusWeightBonus = -362807016

func (*BonusWeightBonus) GetTypeId() int32 {
    return -362807016
}

func (_v *BonusWeightBonus)Deserialize(_buf map[string]interface{}) (err error) {
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["bonuses"].([]interface{}); !_ok_ { err = errors.New("bonuses error"); return }

                _v.Bonuses = make([]*BonusWeightBonusInfo, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *BonusWeightBonusInfo
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBonusWeightBonusInfo(_x_); err != nil { return } }
                    _v.Bonuses = append(_v.Bonuses, _list_v_)
                }
            }

    return
}

func DeserializeBonusWeightBonus(_buf map[string]interface{}) (*BonusWeightBonus, error) {
    v := &BonusWeightBonus{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
