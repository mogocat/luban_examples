
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_DebugPrint struct {
    Ai_Task
    Text string
}

func (Ai_DebugPrint) GetTypeId() int {
    return 1357409728
}

func NewAi_DebugPrint(_buf map[string]interface{}) (_v *Ai_DebugPrint, err error) {
    _v = &Ai_DebugPrint{}
    var _p *Ai_Task
     if _p, err = NewAi_Task(_buf) ; err != nil { return }
    _v.Ai_Task = *_p
    { var _ok_ bool; if _v.Text, _ok_ = _buf["text"].(string); !_ok_ { err = errors.New("text error"); return } }
    return
}
