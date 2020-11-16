using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtentionMethods
{

    public static Vector2 Get4Direction(this Vector2 vector)
    {
        Vector2[] compass = {Vector3.left, Vector3.right, Vector3.forward, Vector3.back, Vector3.up, Vector3.down};

        if (vector.magnitude == 0)
            return (Vector2.zero);
        var maxDot = -Mathf.Infinity;
        var output = Vector3.zero;

        foreach (Vector2 dir in compass)
        {
            float t = Vector3.Dot(vector, dir);
            if (t > maxDot)
            {
                output = dir;
                maxDot = t;
            }
        }

        return output;
    }
}
