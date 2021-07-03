using UnityEngine;

public class DebugHelper
{
    public static void Log(object message,Object context=null)
    {
#if UNITY_EDITOR
        if(context == null)
            Debug.Log(message);
        else
            Debug.Log(message, context);
#endif
    }

    public static void LogWarning(object message,Object context=null)
    {
        if (context == null)
            Debug.LogWarning(message);
        else
            Debug.LogWarning(message, context);
    }

    public static void LogError(object message, Object context = null)
    {
        if (context == null)
            Debug.LogError(message);
        else
            Debug.LogError(message, context);
    }
}
