
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Ai_UeWait struct {
    Ai_Task
    WaitTime float32
    RandomDeviation float32
}


func (Ai_UeWait) GetTypeId() int {
    return -512994101
}


func NewAi_UeWait(_buf *serialization.ByteBuf) (_v *Ai_UeWait, err error) {
    _v = &Ai_UeWait{}

    var _p *Ai_Task
     if _p, err = NewAi_Task(_buf) ; err != nil { return }
    _v.Ai_Task = *_p

    if _v.WaitTime, err = _buf.ReadFloat(); err != nil  { return } 
    if _v.RandomDeviation, err = _buf.ReadFloat(); err != nil  { return } 
    return
}

