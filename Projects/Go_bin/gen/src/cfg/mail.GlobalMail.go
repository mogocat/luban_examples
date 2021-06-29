
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Mail_GlobalMail struct {
    Id int32
    Title string
    Sender string
    Content string
    Award []int32
    AllServer bool
    ServerList []int32
    Platform string
    Channel string
    MinMaxLevel *Condition_MinMaxLevel
    RegisterTime *Condition_TimeRange
    MailTime *Condition_TimeRange
}

func (Mail_GlobalMail) GetTypeId() int {
    return -287571791
}

func NewMail_GlobalMail(_buf *serialization.ByteBuf) (_v *Mail_GlobalMail, err error) {
    _v = &Mail_GlobalMail{}
    if _v.Id, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Title, err = _buf.ReadString(); err != nil  { return } 
    if _v.Sender, err = _buf.ReadString(); err != nil  { return } 
    if _v.Content, err = _buf.ReadString(); err != nil  { return } 
    if _v.Award, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
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
    if _v.AllServer, err = _buf.ReadBool(); err != nil  { return } 
    if _v.ServerList, err = func (_buf2 *serialization.ByteBuf) (_v2 []int32, err2 error) {
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
    if _v.Platform, err = _buf.ReadString(); err != nil  { return } 
    if _v.Channel, err = _buf.ReadString(); err != nil  { return } 
    if _v.MinMaxLevel, err = NewCondition_MinMaxLevel (_buf); err != nil  { return } 
    if _v.RegisterTime, err = NewCondition_TimeRange (_buf); err != nil  { return } 
    if _v.MailTime, err = NewCondition_TimeRange (_buf); err != nil  { return } 
    return
}

