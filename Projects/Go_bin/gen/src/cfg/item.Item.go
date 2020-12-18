
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Item_Item struct {
    
    Id int32
    Name string
    MajorType int32
    MinorType int32
    MaxPileNum int32
    Quality int32
    Icon string
    IconBackgroud string
    IconMask string
    Desc string
    ShowOrder int32
    Quantifier string
    ShowInBag bool
    MinShowLevel int32
    BatchUsable bool
    ProgressTimeWhenUse float32
    ShowHintWhenUse bool
    Droppable bool
    Price int32
    UseType int32
    LevelUpId int32
}


func (Item_Item) GetTypeId() int {
    return 2107285806
}


func NewItem_Item(_buf *serialization.ByteBuf) (_v *Item_Item, err error) {
    _v = &Item_Item{}

    if _v.Id, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Name, err = _buf.ReadString(); err != nil  { return } 
    if _v.MajorType, err = _buf.ReadInt(); err != nil  { return } 
    if _v.MinorType, err = _buf.ReadInt(); err != nil  { return } 
    if _v.MaxPileNum, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Quality, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Icon, err = _buf.ReadString(); err != nil  { return } 
    if _v.IconBackgroud, err = _buf.ReadString(); err != nil  { return } 
    if _v.IconMask, err = _buf.ReadString(); err != nil  { return } 
    if _v.Desc, err = _buf.ReadString(); err != nil  { return } 
    if _v.ShowOrder, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Quantifier, err = _buf.ReadString(); err != nil  { return } 
    if _v.ShowInBag, err = _buf.ReadBool(); err != nil  { return } 
    if _v.MinShowLevel, err = _buf.ReadInt(); err != nil  { return } 
    if _v.BatchUsable, err = _buf.ReadBool(); err != nil  { return } 
    if _v.ProgressTimeWhenUse, err = _buf.ReadFloat(); err != nil  { return } 
    if _v.ShowHintWhenUse, err = _buf.ReadBool(); err != nil  { return } 
    if _v.Droppable, err = _buf.ReadBool(); err != nil  { return } 
    { var _exists bool; if _exists, err = _buf.ReadBool(); err != nil { return }; if _exists { if _v.Price, err = _buf.ReadInt(); err != nil  { return } } }
    if _v.UseType, err = _buf.ReadInt(); err != nil  { return } 
    { var _exists bool; if _exists, err = _buf.ReadBool(); err != nil { return }; if _exists { if _v.LevelUpId, err = _buf.ReadInt(); err != nil  { return } } }
    return
}

