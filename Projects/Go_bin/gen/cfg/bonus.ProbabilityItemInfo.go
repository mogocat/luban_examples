
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type BonusProbabilityItemInfo struct {
    ItemId int32
    Num int32
    Probability float32
}

const TypeId_BonusProbabilityItemInfo = 1547874631

func (*BonusProbabilityItemInfo) GetTypeId() int32 {
    return 1547874631
}

func (_v *BonusProbabilityItemInfo)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusProbabilityItemInfo)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.ItemId, err = _buf.ReadInt(); err != nil { err = errors.New("_v.ItemId error"); return } }
    { if _v.Num, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Num error"); return } }
    { if _v.Probability, err = _buf.ReadFloat(); err != nil { err = errors.New("_v.Probability error"); return } }
    return
}

func DeserializeBonusProbabilityItemInfo(_buf *serialization.ByteBuf) (*BonusProbabilityItemInfo, error) {
    v := &BonusProbabilityItemInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}