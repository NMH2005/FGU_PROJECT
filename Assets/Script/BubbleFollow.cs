using UnityEngine;

public class BubbleFollow : MonoBehaviour {
    private Transform target;
    public Vector3 offset = new Vector3(0,5, 0); // cao hơn đầu nhân vật một chút

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void LateUpdate()
    {
        if (target != null)
            transform.position = target.position + offset;
    }
}
