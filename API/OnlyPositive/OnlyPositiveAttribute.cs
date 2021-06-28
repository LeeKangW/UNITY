using UnityEngine;

public class OnlyPositiveAttribute : PropertyAttribute
{
    /// <summary>
    /// If true, means using only negative
    /// </summary>
    public readonly bool isPositive;

    public OnlyPositiveAttribute(bool isPositive = true)
    {
        this.isPositive = isPositive;
    }
}
