
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_UpdateDailyBehaviorProps struct {
    Ai_Service
    SatietyKey string
    EnergyKey string
    MoodKey string
    SatietyLowerThresholdKey string
    SatietyUpperThresholdKey string
    EnergyLowerThresholdKey string
    EnergyUpperThresholdKey string
    MoodLowerThresholdKey string
    MoodUpperThresholdKey string
}

func (Ai_UpdateDailyBehaviorProps) GetTypeId() int {
    return -61887372
}

func NewAi_UpdateDailyBehaviorProps(_buf map[string]interface{}) (_v *Ai_UpdateDailyBehaviorProps, err error) {
    _v = &Ai_UpdateDailyBehaviorProps{}
    var _p *Ai_Service
     if _p, err = NewAi_Service(_buf) ; err != nil { return }
    _v.Ai_Service = *_p
    { var _ok_ bool; if _v.SatietyKey, _ok_ = _buf["satiety_key"].(string); !_ok_ { err = errors.New("satiety_key error"); return } }
    { var _ok_ bool; if _v.EnergyKey, _ok_ = _buf["energy_key"].(string); !_ok_ { err = errors.New("energy_key error"); return } }
    { var _ok_ bool; if _v.MoodKey, _ok_ = _buf["mood_key"].(string); !_ok_ { err = errors.New("mood_key error"); return } }
    { var _ok_ bool; if _v.SatietyLowerThresholdKey, _ok_ = _buf["satiety_lower_threshold_key"].(string); !_ok_ { err = errors.New("satiety_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.SatietyUpperThresholdKey, _ok_ = _buf["satiety_upper_threshold_key"].(string); !_ok_ { err = errors.New("satiety_upper_threshold_key error"); return } }
    { var _ok_ bool; if _v.EnergyLowerThresholdKey, _ok_ = _buf["energy_lower_threshold_key"].(string); !_ok_ { err = errors.New("energy_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.EnergyUpperThresholdKey, _ok_ = _buf["energy_upper_threshold_key"].(string); !_ok_ { err = errors.New("energy_upper_threshold_key error"); return } }
    { var _ok_ bool; if _v.MoodLowerThresholdKey, _ok_ = _buf["mood_lower_threshold_key"].(string); !_ok_ { err = errors.New("mood_lower_threshold_key error"); return } }
    { var _ok_ bool; if _v.MoodUpperThresholdKey, _ok_ = _buf["mood_upper_threshold_key"].(string); !_ok_ { err = errors.New("mood_upper_threshold_key error"); return } }
    return
}
