
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Ai_Node struct {
    
    Id int32
    NodeName string
}



func NewAi_Node(_buf *serialization.ByteBuf) (_v *Ai_Node, err error) {
    _v = &Ai_Node{}

    if _v.Id, err = _buf.ReadInt(); err != nil  { return } 
    if _v.NodeName, err = _buf.ReadString(); err != nil  { return } 
    return
}

func NewChildAi_Node(_buf *serialization.ByteBuf) (_v interface{}, err error) {
    var id int32
    if id, err = _buf.ReadInt() ; err != nil {
        return
    }
    switch id {
            case 0 : return nil, nil
            case 1812449155: return NewAi_UeSetDefaultFocus(_buf);
            case 990693812: return NewAi_ExecuteTimeStatistic(_buf);
            case 1601247918: return NewAi_ChooseTarget(_buf);
            case 1195270745: return NewAi_KeepFaceTarget(_buf);
            case -999247644: return NewAi_GetOwnerPlayer(_buf);
            case -61887372: return NewAi_UpdateDailyBehaviorProps(_buf);
            case -513308166: return NewAi_UeLoop(_buf);
            case -951439423: return NewAi_UeCooldown(_buf);
            case 338469720: return NewAi_UeTimeLimit(_buf);
            case -315297507: return NewAi_UeBlackboard(_buf);
            case 195054574: return NewAi_UeForceSuccess(_buf);
            case 1255972344: return NewAi_IsAtLocation(_buf);
            case -1207170283: return NewAi_DistanceLessThan(_buf);
            case -1789006105: return NewAi_Sequence(_buf);
            case -1946981627: return NewAi_Selector(_buf);
            case -1952582529: return NewAi_SimpleParallel(_buf);
            case -512994101: return NewAi_UeWait(_buf);
            case 1215378271: return NewAi_UeWaitBlackboardTime(_buf);
            case 514987779: return NewAi_MoveToTarget(_buf);
            case -918812268: return NewAi_ChooseSkill(_buf);
            case -2140042998: return NewAi_MoveToRandomLocation(_buf);
            case -969953113: return NewAi_MoveToLocation(_buf);
            case 1357409728: return NewAi_DebugPrint(_buf);
    }
    return
}

