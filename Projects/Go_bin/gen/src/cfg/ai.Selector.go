
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "bright/serialization"



type Ai_Selector struct {
    Ai_ComposeNode
    Children []interface{}
}


func (Ai_Selector) GetTypeId() int {
    return -1946981627
}


func NewAi_Selector(_buf *serialization.ByteBuf) (_v *Ai_Selector, err error) {
    _v = &Ai_Selector{}

    var _p *Ai_ComposeNode
     if _p, err = NewAi_ComposeNode(_buf) ; err != nil { return }
    _v.Ai_ComposeNode = *_p

    if _v.Children, err = func (_buf2 *serialization.ByteBuf) (_v2 []interface{}, err2 error) {
                _v2 = make([]interface{}, 0)
                var n int
                if n, err2 = _buf2.ReadSize(); err2 != nil {return}
                for i := 0 ; i < n ; i++ {
                    var v3 interface{}
                    if v3, err2 = NewChildAi_FlowNode(_buf2); err2 != nil {return}
                    _v2 = append(_v2, v3)
                }
                return
                }(_buf); err != nil  { return } 
    return
}

