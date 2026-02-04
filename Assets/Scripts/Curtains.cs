using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Curtains : MonoBehaviour
{
    public Animator FadeOut;

    void Awake()
    {
        FadeOut.Play("FadeFromBlack");
    }
    private void OnEnable()
    {
        SceneChecker.CurtainCall += BlackOut;
        SceneChecker.CurtainRise += Awaken;
    }
    private void OnDisable()
    {
        SceneChecker.CurtainCall -= BlackOut;
        SceneChecker.CurtainRise -= Awaken;
    }

    void BlackOut()
    {
        FadeOut.Play("FadeToBlack");
    }
    void Awaken()
    {
        FadeOut.Play("FadeFromBlack");
    }
}
