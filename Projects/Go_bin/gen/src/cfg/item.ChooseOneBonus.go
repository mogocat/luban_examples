
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Item_ChooseOneBonus struct {
    DropId int32
    IsUnique bool
}

func (Item_ChooseOneBonus) GetTypeId() int {
    return 228058347
}

func NewItem_ChooseOneBonus(_buf *serialization.ByteBuf) (_v *Item_ChooseOneBonus, err error) {
    _v = &Item_ChooseOneBonus{}
    if _v.DropId, err = _buf.ReadInt(); err != nil  { return } 
    if _v.IsUnique, err = _buf.ReadBool(); err != nil  { return } 
    return
}

