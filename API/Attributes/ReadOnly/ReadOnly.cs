using UnityEngine;
public class ReadOnly : PropertyAttribute
{
    public readonly bool isRunTimeOnly;

    public ReadOnly(bool runtimeOnly = false)
    {
        isRunTimeOnly = runtimeOnly;
    }
}
