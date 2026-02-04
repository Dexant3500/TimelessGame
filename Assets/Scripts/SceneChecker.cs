using System;
using System.Collections;
using System.Numerics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class SceneChecker : MonoBehaviour
{
    public string SceneToLoad;
    private float FadeDelay=0.5f;
   // public PlayerMovement Player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    private Transform player;
    public UnityEngine.Vector2 Position;
    public static event Action CurtainCall;
    public static event Action CurtainRise;

    


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = collision.transform;
            CurtainCall?.Invoke();
            StartCoroutine(Delay());
        }

    }

    IEnumerator Delay()
    {
        
        string Current = SceneManager.GetActiveScene().name;
        SceneHelper.LoadScene(SceneToLoad);
        Console.WriteLine("Scene Loaded");
        player.position = Position;
        CurtainRise?.Invoke();
        yield return new WaitForSeconds(FadeDelay);
        SceneHelper.UnloadScene(Current);
    }
}

