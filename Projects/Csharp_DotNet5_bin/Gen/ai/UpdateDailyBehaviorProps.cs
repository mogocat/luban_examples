
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed class UpdateDailyBehaviorProps :  ai.Service 
{
    public UpdateDailyBehaviorProps(ByteBuf _buf)  : base(_buf) 
    {
        SatietyKey = _buf.ReadString();
        EnergyKey = _buf.ReadString();
        MoodKey = _buf.ReadString();
        SatietyLowerThresholdKey = _buf.ReadString();
        SatietyUpperThresholdKey = _buf.ReadString();
        EnergyLowerThresholdKey = _buf.ReadString();
        EnergyUpperThresholdKey = _buf.ReadString();
        MoodLowerThresholdKey = _buf.ReadString();
        MoodUpperThresholdKey = _buf.ReadString();
    }

    public static UpdateDailyBehaviorProps DeserializeUpdateDailyBehaviorProps(ByteBuf _buf)
    {
        return new ai.UpdateDailyBehaviorProps(_buf);
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

    public const int __ID__ = -61887372;
    public override int GetTypeId() => __ID__;

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
