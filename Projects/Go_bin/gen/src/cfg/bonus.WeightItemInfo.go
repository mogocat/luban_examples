
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Bonus_WeightItemInfo struct {
    ItemId int32
    Num int32
    Weight int32
}

func (Bonus_WeightItemInfo) GetTypeId() int {
    return 1239999176
}

func NewBonus_WeightItemInfo(_buf *serialization.ByteBuf) (_v *Bonus_WeightItemInfo, err error) {
    _v = &Bonus_WeightItemInfo{}
    if _v.ItemId, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Num, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Weight, err = _buf.ReadInt(); err != nil  { return } 
    return
}

