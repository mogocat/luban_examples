
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type RoleBonusInfo struct {
    Type int32
    Coefficient float32
}

const TypeId_RoleBonusInfo = -1354421803

func (*RoleBonusInfo) GetTypeId() int32 {
    return -1354421803
}

func (_v *RoleBonusInfo)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["type"].(float64); !_ok_ { err = errors.New("type error"); return }; _v.Type = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["coefficient"].(float64); !_ok_ { err = errors.New("coefficient error"); return }; _v.Coefficient = float32(_tempNum_) }
    return
}

func DeserializeRoleBonusInfo(_buf map[string]interface{}) (*RoleBonusInfo, error) {
    v := &RoleBonusInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}