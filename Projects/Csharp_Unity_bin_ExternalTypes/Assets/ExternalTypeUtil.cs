using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalTypeUtil
{
    public static UnityEngine.Color NewFromCfgColor(cfg.test.Color color)
    {
        return new Color(color.R, color.G, color.B, color.A);
    }
}
