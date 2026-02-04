using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class InputSystem : MonoBehaviour
{
    private Rigidbody2D RB;
    private PlayerInput playerInput;
    public float speed;
    public float DashForce;
    private Vector2 Input;
    [SerializeField] private Cooldown DashCooldown;
    [SerializeField] private Cooldown StopCooldown;
     

    void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }
    void Update()
    {

        while (RB.linearVelocityX >= 20) RB.linearVelocityX--;

        while (RB.linearVelocityX <= -20) RB.linearVelocityX++;

        while (RB.linearVelocityY >= 20) RB.linearVelocityY--;

        while (RB.linearVelocityY <= -20) RB.linearVelocityY++;

    }
    public void FullStop(InputAction.CallbackContext context)
    {
        if (StopCooldown.IsCooldown) return;

        RB.linearVelocityX = 0;
        RB.linearVelocityY = 0;

        StopCooldown.StartCooldown();
    }

    public void Dash(InputAction.CallbackContext context)
    {
        if (DashCooldown.IsCooldown) return;

        RB.AddForce(new Vector2(Input.x, Input.y) * DashForce, ForceMode2D.Impulse);

        DashCooldown.StartCooldown();
    }
    public void Move(InputAction.CallbackContext context)
    {
        Input = context.ReadValue<Vector2>();
        RB.AddForce(new Vector2(Input.x, Input.y) * speed);

    }
    /*
    public void SceneEnter(float X, float Y, Vector2 direction)
    {
        RB.position = new Vector2(X, Y);
        RB.AddForce(direction*10);
    }
    */
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Damage")
            Debug.Log("Game Over");
    }
}


