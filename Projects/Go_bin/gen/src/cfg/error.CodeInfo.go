
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Error_CodeInfo struct {
    Code int32
    Key string
}

func (Error_CodeInfo) GetTypeId() int {
    return -1942481535
}

func NewError_CodeInfo(_buf *serialization.ByteBuf) (_v *Error_CodeInfo, err error) {
    _v = &Error_CodeInfo{}
    if _v.Code, err = _buf.ReadInt(); err != nil  { return } 
    if _v.Key, err = _buf.ReadString(); err != nil  { return } 
    return
}

