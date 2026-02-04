using Unity.VisualScripting;
using UnityEngine;

public class Damage_Dealers : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Player")
        Debug.Log("Game Over");
        
    }
}
