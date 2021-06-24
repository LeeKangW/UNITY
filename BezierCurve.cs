using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LeeKangW
{
    namespace API
    {
        public class BezierCurve
        {
            public static Vector3? GetBezierCurvePoint(Vector3 p1,Vector3 p2,Vector3? p3,Vector3? p4, float value)
            {
                if(!p3.HasValue && !p4.HasValue)
                {
                    return Vector3.Lerp(p1, p2, value);
                }

                if(p3.HasValue && !p4.HasValue)
                {
                    Vector3 newP0 = Vector3.Lerp(p1, p2, value);
                    Vector3 newP1 = Vector3.Lerp(p2, p3.Value, value);

                    return Vector3.Lerp(newP0, newP1, value);
                }

                if (p3.HasValue && p4.HasValue)
                {
                    Vector3 newP0 = Vector3.Lerp(p1, p2, value);
                    Vector3 newP1 = Vector3.Lerp(p2, p3.Value, value);
                    Vector3 newp2 = Vector3.Lerp(p3.Value, p4.Value, value);

                    Vector3 newp3 = Vector3.Lerp(newP0, newP1, value);
                    Vector3 newp4 = Vector3.Lerp(newP1, newp2, value);

                    return Vector3.Lerp(newp3, newp4, value);
                }

                return null;
            }
        }
    }
}
