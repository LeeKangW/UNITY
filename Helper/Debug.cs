using UnityEngine;

namespace Helper
{
    public class Debug
    {
        public static void Log(object message, Object context = null)
        {
#if UNITY_EDITOR
            if (context == null)
                UnityEngine.Debug.Log(message);
            else
                UnityEngine.Debug.Log(message, context);
#endif
        }

        public static void LogWarning(object message, Object context = null)
        {
            if (context == null)
                UnityEngine.Debug.LogWarning(message);
            else
                UnityEngine.Debug.LogWarning(message, context);
        }

        public static void LogError(object message, Object context = null)
        {
            if (context == null)
                UnityEngine.Debug.LogError(message);
            else
                UnityEngine.Debug.LogError(message, context);
        }
    }
}
