using System;
using System.Collections;
using UnityEngine;


namespace Helper
{
    public class Coroutine
    {
        public static readonly WaitForSeconds wait0ms = new WaitForSeconds(0f);
        public static readonly WaitForSeconds wait100ms = new WaitForSeconds(0.1f);
        public static readonly WaitForSeconds wait500ms = new WaitForSeconds(0.5f);
        public static readonly WaitForSeconds wait1000ms = new WaitForSeconds(1f);
        public static IEnumerator WaitUntil(Func<bool> func)
        {
            while (!func())
            {
                yield return wait0ms;
            }
        }
    }
}
