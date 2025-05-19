using System.Collections.Generic;
using UnityEngine;

public class AlongPath : MonoBehaviour
{
    public bool isLYStart;
    public Transform target;
    public float velocity;
    private List<Vector2> path = new List<Vector2>();

    public List<Transform> points;
    public LineRenderer lineRenderer;

    private float totalLength;
    private float currentS;
    private int index = 0;

    void Start()
    {
        isLYStart = false;

        List<Vector2> controlPoints = new List<Vector2>();

        foreach (var point in points)
        {
            controlPoints.Add(point.position);
        }

        path = Bezier.BezierInterpolateList(controlPoints, 50);

        lineRenderer.positionCount = path.Count;

        for (int i = 1; i < path.Count; i++)
        {
            totalLength += (path[i] - path[i - 1]).magnitude;
        }
    }

    Vector3 dir;
    Vector3 pos;

    private void FixedUpdate()
    {
        Debug.Log(target.position);
        if(isLYStart)
        { 
            float s = (velocity * 10 / 36) * Time.time;
            if (currentS < totalLength)
            {
                for (int i = index; i < path.Count - 1; i++)
                {
                    currentS += (path[i + 1] - path[i]).magnitude;
                    if (currentS > s)
                    {
                        index = i;
                        currentS -= (path[i + 1] - path[i]).magnitude;
                        dir = (path[i + 1] - path[i]).normalized;
                        pos = new Vector3(path[i].x + dir.x * (s - currentS), path[i].y + dir.y * (s - currentS), 0);
                        break;
                    }
                }
                transform.position = pos;
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Vector3.forward, dir), Time.deltaTime * 5);
            }
            if (target != null)
            {
                target.position = pos;
                target.rotation = Quaternion.LookRotation(Vector3.forward, dir);
            }
        }
    }
}
