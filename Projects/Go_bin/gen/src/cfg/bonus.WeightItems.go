
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Bonus_WeightItems struct {
    Bonus_Bonus
    ItemList []*Bonus_WeightItemInfo
}


func (Bonus_WeightItems) GetTypeId() int {
    return -356202311
}


func NewBonus_WeightItems(_buf *serialization.ByteBuf) (_v *Bonus_WeightItems, err error) {
    _v = &Bonus_WeightItems{}

    var _p *Bonus_Bonus
     if _p, err = NewBonus_Bonus(_buf) ; err != nil { return }
    _v.Bonus_Bonus = *_p

    if _v.ItemList, err = func (_buf2 *serialization.ByteBuf) (_v2 []*Bonus_WeightItemInfo, err2 error) {
                _v2 = make([]*Bonus_WeightItemInfo, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 *Bonus_WeightItemInfo
                    if v3, err2 = NewBonus_WeightItemInfo (_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

