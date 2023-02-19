using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProduct : MonoBehaviour
{
    public Transform V1;
    public Transform V2;

    private void OnDrawGizmos()
    {
        if (V1 == null || V2 == null) return;
        Gizmos.color = Color.yellow;
        Vector3 vector1 = V1.position;
        DrawVector(transform.position, vector1);
        Gizmos.color = Color.blue;
        Vector3 vector2 = V2.position;
        DrawVector(transform.position, vector2);

        float dot = Vector3.Dot(vector1.normalized, vector2.normalized);
        Color color = new Color(0f, 0f, 0f, 1f);
        if (dot > 0)
        {
            color.g = dot;
        }
        else
        {
            color.r = -dot;
        }
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, 1f);
    }
    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start, 0.25f);
    }
}
