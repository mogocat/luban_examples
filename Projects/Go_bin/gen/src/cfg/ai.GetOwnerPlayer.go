
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Ai_GetOwnerPlayer struct {
    Ai_Service
    PlayerActorKey string
}


func (Ai_GetOwnerPlayer) GetTypeId() int {
    return -999247644
}


func NewAi_GetOwnerPlayer(_buf *serialization.ByteBuf) (_v *Ai_GetOwnerPlayer, err error) {
    _v = &Ai_GetOwnerPlayer{}

    var _p *Ai_Service
     if _p, err = NewAi_Service(_buf) ; err != nil { return }
    _v.Ai_Service = *_p

    if _v.PlayerActorKey, err = _buf.ReadString(); err != nil  { return } 
    return
}

