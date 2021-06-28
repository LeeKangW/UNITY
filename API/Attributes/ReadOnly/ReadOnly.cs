using UnityEngine;
public class ReadOnly : PropertyAttribute
{
    /// <summary>
    /// If true, Can Edit before playing Game
    /// </summary>
    public readonly bool isRunTimeOnly;

    public ReadOnly(bool runtimeOnly = false)
    {
        isRunTimeOnly = runtimeOnly;
    }
}
