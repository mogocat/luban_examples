
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiNode struct {
    Id int32
    NodeName string
}

const TypeId_AiNode = -1055479768

func (*AiNode) GetTypeId() int32 {
    return -1055479768
}

func (_v *AiNode)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    return
}

func DeserializeAiNode(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "UeSetDefaultFocus": _v := &AiUeSetDefaultFocus{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeSetDefaultFocus") } else { return _v, nil }
        case "ExecuteTimeStatistic": _v := &AiExecuteTimeStatistic{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ExecuteTimeStatistic") } else { return _v, nil }
        case "ChooseTarget": _v := &AiChooseTarget{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ChooseTarget") } else { return _v, nil }
        case "KeepFaceTarget": _v := &AiKeepFaceTarget{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.KeepFaceTarget") } else { return _v, nil }
        case "GetOwnerPlayer": _v := &AiGetOwnerPlayer{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.GetOwnerPlayer") } else { return _v, nil }
        case "UpdateDailyBehaviorProps": _v := &AiUpdateDailyBehaviorProps{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UpdateDailyBehaviorProps") } else { return _v, nil }
        case "UeLoop": _v := &AiUeLoop{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeLoop") } else { return _v, nil }
        case "UeCooldown": _v := &AiUeCooldown{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeCooldown") } else { return _v, nil }
        case "UeTimeLimit": _v := &AiUeTimeLimit{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeTimeLimit") } else { return _v, nil }
        case "UeBlackboard": _v := &AiUeBlackboard{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeBlackboard") } else { return _v, nil }
        case "UeForceSuccess": _v := &AiUeForceSuccess{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeForceSuccess") } else { return _v, nil }
        case "IsAtLocation": _v := &AiIsAtLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.IsAtLocation") } else { return _v, nil }
        case "DistanceLessThan": _v := &AiDistanceLessThan{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.DistanceLessThan") } else { return _v, nil }
        case "Sequence": _v := &AiSequence{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.Sequence") } else { return _v, nil }
        case "Selector": _v := &AiSelector{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.Selector") } else { return _v, nil }
        case "SimpleParallel": _v := &AiSimpleParallel{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.SimpleParallel") } else { return _v, nil }
        case "UeWait": _v := &AiUeWait{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeWait") } else { return _v, nil }
        case "UeWaitBlackboardTime": _v := &AiUeWaitBlackboardTime{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.UeWaitBlackboardTime") } else { return _v, nil }
        case "MoveToTarget": _v := &AiMoveToTarget{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToTarget") } else { return _v, nil }
        case "ChooseSkill": _v := &AiChooseSkill{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.ChooseSkill") } else { return _v, nil }
        case "MoveToRandomLocation": _v := &AiMoveToRandomLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToRandomLocation") } else { return _v, nil }
        case "MoveToLocation": _v := &AiMoveToLocation{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.MoveToLocation") } else { return _v, nil }
        case "DebugPrint": _v := &AiDebugPrint{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("ai.DebugPrint") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
