using UnityEngine;

public class Spear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       bool used=false;     
    }
    void Attack()
    {
        Animation animation = GetComponent<Animation>();
        animation.Play();
        
    }

}
