using UnityEngine;
public class ReadOnlyAttribute : PropertyAttribute
{
    /// <summary>
    /// If true, Can Edit before playing Game
    /// </summary>
    public readonly bool isRunTimeOnly;

    public ReadOnlyAttribute(bool runtimeOnly = false)
    {
        isRunTimeOnly = runtimeOnly;
    }
}
