using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Curtains : MonoBehaviour
{
    public Animator FadeOut;

    private void OnEnable()
    {
        SceneChecker.CurtainCall += BlackOut;
    }
    private void OnDisable()
    {
        SceneChecker.CurtainCall -= BlackOut;
    }

    void BlackOut()
    {
        FadeOut.Play("FTB");
    }

}
