
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiGetOwnerPlayer struct {
    Id int32
    NodeName string
    PlayerActorKey string
}

const TypeId_AiGetOwnerPlayer = -999247644

func (*AiGetOwnerPlayer) GetTypeId() int32 {
    return -999247644
}

func (_v *AiGetOwnerPlayer)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    { var _ok_ bool; if _v.PlayerActorKey, _ok_ = _buf["player_actor_key"].(string); !_ok_ { err = errors.New("player_actor_key error"); return } }
    return
}

func DeserializeAiGetOwnerPlayer(_buf map[string]interface{}) (*AiGetOwnerPlayer, error) {
    v := &AiGetOwnerPlayer{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
