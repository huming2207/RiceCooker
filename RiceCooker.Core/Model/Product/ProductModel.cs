using System;
using System.Runtime.Serialization;

namespace RiceCooker.Core.Model.Product
{
    public enum ProductModel
    {
        [EnumMember(Value = "gateway")]
        MiHomeGateway,
        
        [EnumMember(Value = "plug")]
        MiHomeSmartPlug,
        
        [EnumMember(Value = "switch")]
        MiHomeWirelessSwitch,
        
        [EnumMember(Value = "motion")]
        MiHomeMotionSensor,
        
        [EnumMember(Value = "magnet")]
        MiHomeWindowMagnetSensor,
        
        [EnumMember(Value = "ctrl_neutral1")]
        AqaraPowerSwitchSingle,
        
        [EnumMember(Value = "ctrl_neutral2")]
        AqaraPowerSwitchDual,
        
        [EnumMember(Value = "86sw1")]
        Aqara86WirelessSwitchSingle,
        
        [EnumMember(Value = "86sw2")]
        Aqara86WirelessSwitchDual,
        
        [EnumMember(Value = "sensor_ht")]
        MiHomeHumidTempSensor,
        
        [EnumMember(Value = "cube")]
        MiHomeCubeSensor,
        
        [EnumMember(Value = "curtain")]
        AqaraCurtain,
        
        [EnumMember(Value = "ctrl_ln1")]
        Aqara86PowerSwitchSingle,
        
        [EnumMember(Value = "ctrl_ln2")]
        Aqara86PowerSwitchDual,
        
        [EnumMember(Value = "86plug")]
        Aqara86SmartPlug,
        
        [EnumMember(Value = "natgas")]
        MiHomeGasSensor,
        
        [EnumMember(Value = "smoke")]
        MiHomeSmokeAlarm, // Should be better than RMIT's fire alarm lol
        
        [EnumMember(Value = "sensor_magnet.aq2")]
        AqaraDoorMagnetSensor
        
        // TBD...
    }
}