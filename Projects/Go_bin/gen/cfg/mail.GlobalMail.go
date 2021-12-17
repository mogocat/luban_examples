
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

type MailGlobalMail struct {
    Id int32
    Title string
    Sender string
    Content string
    Award []int32
    AllServer bool
    ServerList []int32
    Platform string
    Channel string
    MinMaxLevel *ConditionMinMaxLevel
    RegisterTime *ConditionTimeRange
    MailTime *ConditionTimeRange
}

const TypeId_MailGlobalMail = -287571791

func (*MailGlobalMail) GetTypeId() int32 {
    return -287571791
}

func (_v *MailGlobalMail)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *MailGlobalMail)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.Title, err = _buf.ReadString(); err != nil { err = errors.New("_v.Title error"); return } }
    { if _v.Sender, err = _buf.ReadString(); err != nil { err = errors.New("_v.Sender error"); return } }
    { if _v.Content, err = _buf.ReadString(); err != nil { err = errors.New("_v.Content error"); return } }
    {_v.Award = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Award error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("_e_ error"); return } }; _v.Award = append(_v.Award, _e_) } }
    { if _v.AllServer, err = _buf.ReadBool(); err != nil { err = errors.New("_v.AllServer error"); err = errors.New("_v.AllServer error"); return } }
    {_v.ServerList = make([]int32, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.ServerList error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ int32; { if _e_, err = _buf.ReadInt(); err != nil { err = errors.New("_e_ error"); return } }; _v.ServerList = append(_v.ServerList, _e_) } }
    { if _v.Platform, err = _buf.ReadString(); err != nil { err = errors.New("_v.Platform error"); return } }
    { if _v.Channel, err = _buf.ReadString(); err != nil { err = errors.New("_v.Channel error"); return } }
    { if _v.MinMaxLevel, err = DeserializeConditionMinMaxLevel(_buf); err != nil { err = errors.New("_v.MinMaxLevel error"); return } }
    { if _v.RegisterTime, err = DeserializeConditionTimeRange(_buf); err != nil { err = errors.New("_v.RegisterTime error"); return } }
    { if _v.MailTime, err = DeserializeConditionTimeRange(_buf); err != nil { err = errors.New("_v.MailTime error"); return } }
    return
}

func DeserializeMailGlobalMail(_buf *serialization.ByteBuf) (*MailGlobalMail, error) {
    v := &MailGlobalMail{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}