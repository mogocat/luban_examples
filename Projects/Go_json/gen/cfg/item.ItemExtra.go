
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type ItemItemExtra struct {
    Id int32
}

const TypeId_ItemItemExtra = 23433090

func (*ItemItemExtra) GetTypeId() int32 {
    return 23433090
}

func (_v *ItemItemExtra)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    return
}

func DeserializeItemItemExtra(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "TreasureBox": _v := &ItemTreasureBox{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("item.TreasureBox") } else { return _v, nil }
        case "InteractionItem": _v := &ItemInteractionItem{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("item.InteractionItem") } else { return _v, nil }
        case "Clothes": _v := &ItemClothes{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("item.Clothes") } else { return _v, nil }
        case "DesignDrawing": _v := &ItemDesignDrawing{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("item.DesignDrawing") } else { return _v, nil }
        case "Dymmy": _v := &ItemDymmy{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("item.Dymmy") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}