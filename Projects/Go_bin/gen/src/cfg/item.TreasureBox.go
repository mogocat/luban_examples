
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Item_TreasureBox struct {
    Item_ItemExtra
    KeyItemId int32
    OpenLevel *Condition_MinLevel
    UseOnObtain bool
    DropIds []int32
    ChooseList []*Item_ChooseOneBonus
}


func (Item_TreasureBox) GetTypeId() int {
    return 1494222369
}


func NewItem_TreasureBox(_buf *serialization.ByteBuf) (_v *Item_TreasureBox, err error) {
    _v = &Item_TreasureBox{}

    var _p *Item_ItemExtra
     if _p, err = NewItem_ItemExtra(_buf) ; err != nil { return }
    _v.Item_ItemExtra = *_p

    { var _exists bool; if _exists, err = _buf.ReadBool(); err != nil { return }; if _exists { if _v.KeyItemId, err = _buf.ReadInt(); err != nil  { return } } }
    if _v.OpenLevel, err = NewCondition_MinLevel (_buf); err != nil  { return } 
    if _v.UseOnObtain, err = _buf.ReadBool(); err != nil  { return } 
    if _v.DropIds, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
                _v2 = make([]int32, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 int32
                    if v3, err2 = _buf2.ReadInt(); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    if _v.ChooseList, err = func (_buf2 *serialization.ByteBuf) (_v2 []*Item_ChooseOneBonus, err2 error) {
                _v2 = make([]*Item_ChooseOneBonus, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 *Item_ChooseOneBonus
                    if v3, err2 = NewItem_ChooseOneBonus (_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

