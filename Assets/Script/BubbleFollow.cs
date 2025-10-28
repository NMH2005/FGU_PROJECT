using UnityEngine;

public class BubbleFollow : MonoBehaviour {
    public Transform target; // nhân vật đang nói
    public Vector3 offset;   // khoảng cách so với nhân vật

    void LateUpdate()
    {
        if (target != null)
            transform.position = target.position + offset;
    }
}
