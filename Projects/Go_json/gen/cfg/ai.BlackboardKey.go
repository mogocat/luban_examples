
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiBlackboardKey struct {
    Name string
    Desc string
    IsStatic bool
    Type int32
    TypeClassName string
}

const TypeId_AiBlackboardKey = -511559886

func (*AiBlackboardKey) GetTypeId() int32 {
    return -511559886
}

func (_v *AiBlackboardKey)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; if _v.IsStatic, _ok_ = _buf["is_static"].(bool); !_ok_ { err = errors.New("is_static error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["type"].(float64); !_ok_ { err = errors.New("type error"); return }; _v.Type = int32(_tempNum_) }
    { var _ok_ bool; if _v.TypeClassName, _ok_ = _buf["type_class_name"].(string); !_ok_ { err = errors.New("type_class_name error"); return } }
    return
}

func DeserializeAiBlackboardKey(_buf map[string]interface{}) (*AiBlackboardKey, error) {
    v := &AiBlackboardKey{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}