
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiBehaviorTree struct {
    Id int32
    Name string
    Desc string
    BlackboardId string
    Root interface{}
}

const TypeId_AiBehaviorTree = 159552822

func (*AiBehaviorTree) GetTypeId() int32 {
    return 159552822
}

func (_v *AiBehaviorTree)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    { var _ok_ bool; if _v.BlackboardId, _ok_ = _buf["blackboard_id"].(string); !_ok_ { err = errors.New("blackboard_id error"); return } }
    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _buf["root"].(map[string]interface{}); !_ok_ { err = errors.New("root error"); return }; if _v.Root, err = DeserializeAiComposeNode(_x_); err != nil { return } }
    return
}

func DeserializeAiBehaviorTree(_buf map[string]interface{}) (*AiBehaviorTree, error) {
    v := &AiBehaviorTree{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
