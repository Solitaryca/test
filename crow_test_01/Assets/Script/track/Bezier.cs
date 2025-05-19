using System.Collections.Generic;
using UnityEngine;

public class Bezier
{
    internal static Vector2 BezierInterpolate(List<Vector2> points, float t)
    {
        int count = points.Count;

        if (count == 1)
        {
            return points[0];
        }

        List<Vector2> pointList = new List<Vector2>();

        for (int i = 0; i < count - 1; i++)
        {
            Vector2 p = Vector2.Lerp(points[i], points[i + 1], t);
            pointList.Add(p);
        }

        return BezierInterpolate(pointList, t);
    }

    // 根据控制点生成一系列的贝塞尔点
    internal static List<Vector2> BezierInterpolateList(List<Vector2> controlPoints, int pointCount)
    {
        List<Vector2> pointList = new List<Vector2>();

        for (int i = 0; i < pointCount; i++)
        {
            float t = (float)i / (pointCount - 1); 
            pointList.Add(BezierInterpolate(controlPoints, t));
        }
        return pointList;
    }
}
