
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type BlueprintInterface struct {
    Name string
    Desc string
    Parents []interface{}
    Methods []interface{}
}

const TypeId_BlueprintInterface = 2114170750

func (*BlueprintInterface) GetTypeId() int32 {
    return 2114170750
}

func (_v *BlueprintInterface)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["parents"].([]interface{}); !_ok_ { err = errors.New("parents error"); return }

                _v.Parents = make([]interface{}, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ interface{}
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBlueprintClazz(_x_); err != nil { return } }
                    _v.Parents = append(_v.Parents, _list_v_)
                }
            }

     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["methods"].([]interface{}); !_ok_ { err = errors.New("methods error"); return }

                _v.Methods = make([]interface{}, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ interface{}
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeBlueprintMethod(_x_); err != nil { return } }
                    _v.Methods = append(_v.Methods, _list_v_)
                }
            }

    return
}

func DeserializeBlueprintInterface(_buf map[string]interface{}) (*BlueprintInterface, error) {
    v := &BlueprintInterface{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
