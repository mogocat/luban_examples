
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

type AiBinaryOperator struct {
    Oper int32
    Data interface{}
}

const TypeId_AiBinaryOperator = -979891605

func (*AiBinaryOperator) GetTypeId() int32 {
    return -979891605
}

func (_v *AiBinaryOperator)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiBinaryOperator)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Oper, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Oper error"); return } }
    { if _v.Data, err = DeserializeAiKeyData(_buf); err != nil { err = errors.New("_v.Data error"); return } }
    return
}

func DeserializeAiBinaryOperator(_buf *serialization.ByteBuf) (*AiBinaryOperator, error) {
    v := &AiBinaryOperator{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}