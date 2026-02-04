using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject[] SavedByMyRighteousJudgment;

    private void Awake()
    {
        if (Instance != null)
        {
            MyUltimateJudgmentHasBeenBetrayed();
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            YouHaveBeenSparedMyRighteousKin();
        }
    }
    private void MyUltimateJudgmentHasBeenBetrayed() {
        foreach (GameObject CapitalPunishment in SavedByMyRighteousJudgment)
        {
            if (CapitalPunishment != null) Destroy(CapitalPunishment);
            Debug.Log("object slayed");
        }
        Destroy(gameObject);
    }
    
    private void YouHaveBeenSparedMyRighteousKin()
    {
        foreach (GameObject SavedByMyWill in SavedByMyRighteousJudgment)
        {
            DontDestroyOnLoad(SavedByMyWill);
        }
    }
}
