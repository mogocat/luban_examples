
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

type BonusProbabilityBonus struct {
    Bonuses []*BonusProbabilityBonusInfo
}

const TypeId_BonusProbabilityBonus = 359783161

func (*BonusProbabilityBonus) GetTypeId() int32 {
    return 359783161
}

func (_v *BonusProbabilityBonus)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusProbabilityBonus)Deserialize(_buf *serialization.ByteBuf) (err error) {
    {_v.Bonuses = make([]*BonusProbabilityBonusInfo, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Bonuses error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ *BonusProbabilityBonusInfo; { if _e_, err = DeserializeBonusProbabilityBonusInfo(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Bonuses = append(_v.Bonuses, _e_) } }
    return
}

func DeserializeBonusProbabilityBonus(_buf *serialization.ByteBuf) (*BonusProbabilityBonus, error) {
    v := &BonusProbabilityBonus{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}