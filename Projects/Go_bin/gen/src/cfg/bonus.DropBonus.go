
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Bonus_DropBonus struct {
    Bonus_Bonus
    Id int32
}


func (Bonus_DropBonus) GetTypeId() int {
    return 1959868225
}


func NewBonus_DropBonus(_buf *serialization.ByteBuf) (_v *Bonus_DropBonus, err error) {
    _v = &Bonus_DropBonus{}

    var _p *Bonus_Bonus
     if _p, err = NewBonus_Bonus(_buf) ; err != nil { return }
    _v.Bonus_Bonus = *_p

    if _v.Id, err = _buf.ReadInt(); err != nil  { return } 
    return
}

