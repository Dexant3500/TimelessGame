using Unity.VisualScripting;
using UnityEngine;

public class Spear : MonoBehaviour
{
    void Awake()
    {
           
    }
    
    void Attack()
    {
        bool HitSmth=false;
        Animator animaciq = GetComponent<Animator>();
        animaciq.SetBool("Attacked", true);
        while (HitSmth == false)
        {
            
        }
    }

}
