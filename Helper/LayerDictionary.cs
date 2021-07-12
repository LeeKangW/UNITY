using System.Collections;
using System.Collections.Generic;
using System;

public static class LayerDictionary
{
    public enum ELayer
    {
        Default,
        TransparentFX,
        Ignore_Raycast,
        Map,
        Water,
        UI,
        Enemy,
    }

    static Dictionary<ELayer, string> layerDictionary = new Dictionary<ELayer, string>();

    static void Init()
    {
        layerDictionary = new Dictionary<ELayer, string>(Enum.GetValues(typeof(ELayer)).Length);

        string temp = string.Empty;

        foreach (var item in ELayer.GetValues(typeof(ELayer)))
        {
            if (item.ToString().Contains("_"))
            {
                temp = item.ToString().Replace("_", " ");
            }
            else
            {
                temp = item.ToString();
            }
            layerDictionary.Add((ELayer)item, temp);
        }
    }

    static public string GetLayerName(ELayer tag)
    {
        if (layerDictionary == null || layerDictionary.Count == 0)
            Init();

        return layerDictionary.GetOrDefault(tag);
    }
}
