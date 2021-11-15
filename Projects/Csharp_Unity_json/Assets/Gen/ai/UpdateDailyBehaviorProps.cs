
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.ai
{

public sealed class UpdateDailyBehaviorProps :  ai.Service 
{
    public UpdateDailyBehaviorProps(JSONNode _json)  : base(_json) 
    {
        { if(!_json["satiety_key"].IsString) { throw new SerializationException(); }  SatietyKey = _json["satiety_key"]; }
        { if(!_json["energy_key"].IsString) { throw new SerializationException(); }  EnergyKey = _json["energy_key"]; }
        { if(!_json["mood_key"].IsString) { throw new SerializationException(); }  MoodKey = _json["mood_key"]; }
        { if(!_json["satiety_lower_threshold_key"].IsString) { throw new SerializationException(); }  SatietyLowerThresholdKey = _json["satiety_lower_threshold_key"]; }
        { if(!_json["satiety_upper_threshold_key"].IsString) { throw new SerializationException(); }  SatietyUpperThresholdKey = _json["satiety_upper_threshold_key"]; }
        { if(!_json["energy_lower_threshold_key"].IsString) { throw new SerializationException(); }  EnergyLowerThresholdKey = _json["energy_lower_threshold_key"]; }
        { if(!_json["energy_upper_threshold_key"].IsString) { throw new SerializationException(); }  EnergyUpperThresholdKey = _json["energy_upper_threshold_key"]; }
        { if(!_json["mood_lower_threshold_key"].IsString) { throw new SerializationException(); }  MoodLowerThresholdKey = _json["mood_lower_threshold_key"]; }
        { if(!_json["mood_upper_threshold_key"].IsString) { throw new SerializationException(); }  MoodUpperThresholdKey = _json["mood_upper_threshold_key"]; }
    }

    public UpdateDailyBehaviorProps(int id, string node_name, string satiety_key, string energy_key, string mood_key, string satiety_lower_threshold_key, string satiety_upper_threshold_key, string energy_lower_threshold_key, string energy_upper_threshold_key, string mood_lower_threshold_key, string mood_upper_threshold_key )  : base(id,node_name) 
    {
        this.SatietyKey = satiety_key;
        this.EnergyKey = energy_key;
        this.MoodKey = mood_key;
        this.SatietyLowerThresholdKey = satiety_lower_threshold_key;
        this.SatietyUpperThresholdKey = satiety_upper_threshold_key;
        this.EnergyLowerThresholdKey = energy_lower_threshold_key;
        this.EnergyUpperThresholdKey = energy_upper_threshold_key;
        this.MoodLowerThresholdKey = mood_lower_threshold_key;
        this.MoodUpperThresholdKey = mood_upper_threshold_key;
    }

    public static UpdateDailyBehaviorProps DeserializeUpdateDailyBehaviorProps(JSONNode _json)
    {
        return new ai.UpdateDailyBehaviorProps(_json);
    }

    public string SatietyKey { get; private set; }
    public string EnergyKey { get; private set; }
    public string MoodKey { get; private set; }
    public string SatietyLowerThresholdKey { get; private set; }
    public string SatietyUpperThresholdKey { get; private set; }
    public string EnergyLowerThresholdKey { get; private set; }
    public string EnergyUpperThresholdKey { get; private set; }
    public string MoodLowerThresholdKey { get; private set; }
    public string MoodUpperThresholdKey { get; private set; }

    public const int ID = -61887372;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "SatietyKey:" + SatietyKey + ","
        + "EnergyKey:" + EnergyKey + ","
        + "MoodKey:" + MoodKey + ","
        + "SatietyLowerThresholdKey:" + SatietyLowerThresholdKey + ","
        + "SatietyUpperThresholdKey:" + SatietyUpperThresholdKey + ","
        + "EnergyLowerThresholdKey:" + EnergyLowerThresholdKey + ","
        + "EnergyUpperThresholdKey:" + EnergyUpperThresholdKey + ","
        + "MoodLowerThresholdKey:" + MoodLowerThresholdKey + ","
        + "MoodUpperThresholdKey:" + MoodUpperThresholdKey + ","
        + "}";
    }
    }
}
