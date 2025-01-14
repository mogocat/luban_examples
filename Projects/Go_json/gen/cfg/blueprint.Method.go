
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BlueprintMethod struct {
    Name string
    Desc string
    IsStatic bool
    ReturnType string
    Parameters []*BlueprintParamInfo
}

const TypeId_BlueprintMethod = 1176452284

func (*BlueprintMethod) GetTypeId() int32 {
    return 1176452284
}

func (_v *BlueprintMethod)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; if _v.IsStatic, _ok_ = _buf["is_static"].(bool); !_ok_ { err = errors.New("is_static error"); return } }
    { var _ok_ bool; if _v.ReturnType, _ok_ = _buf["return_type"].(string); !_ok_ { err = errors.New("return_type error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["parameters"].([]interface{}); !_ok_ { err = errors.New("parameters error"); return }

                _v.Parameters = make([]*BlueprintParamInfo, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *BlueprintParamInfo
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBlueprintParamInfo(_x_); err != nil { return } }
                    _v.Parameters = append(_v.Parameters, _list_v_)
                }
            }

    return
}

func DeserializeBlueprintMethod(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "AbstraceMethod": _v := &BlueprintAbstraceMethod{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("blueprint.AbstraceMethod") } else { return _v, nil }
        case "ExternalMethod": _v := &BlueprintExternalMethod{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("blueprint.ExternalMethod") } else { return _v, nil }
        case "BlueprintMethod": _v := &BlueprintBlueprintMethod{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("blueprint.BlueprintMethod") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
