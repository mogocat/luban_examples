
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "bright/serialization"
)

import "errors"

type TestMultiIndexList struct {
    Id1 int32
    Id2 int64
    Id3 string
    Num int32
    Desc string
}

const TypeId_TestMultiIndexList = 2016237651

func (*TestMultiIndexList) GetTypeId() int32 {
    return 2016237651
}

func (_v *TestMultiIndexList)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestMultiIndexList)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id1, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id1 error"); return } }
    { if _v.Id2, err = _buf.ReadLong(); err != nil { err = errors.New("_v.Id2 error"); return } }
    { if _v.Id3, err = _buf.ReadString(); err != nil { err = errors.New("_v.Id3 error"); return } }
    { if _v.Num, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Num error"); return } }
    { if _v.Desc, err = _buf.ReadString(); err != nil { err = errors.New("_v.Desc error"); return } }
    return
}

func DeserializeTestMultiIndexList(_buf *serialization.ByteBuf) (*TestMultiIndexList, error) {
    v := &TestMultiIndexList{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}