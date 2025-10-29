using UnityEngine;

public class FX_AutoDestroy : MonoBehaviour
{
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
