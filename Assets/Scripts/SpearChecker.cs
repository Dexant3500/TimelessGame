using UnityEngine;

public class SpearChecker : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SendMessageUpwards("Attack", SendMessageOptions.DontRequireReceiver);

    }
}
