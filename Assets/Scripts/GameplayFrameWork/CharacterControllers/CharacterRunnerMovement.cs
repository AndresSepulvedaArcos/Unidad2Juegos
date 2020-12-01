using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 


public class CharacterRunnerMovement : SerializedMonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 1f;
    public float customGravity = 2f;
    public float jumpForce = 2f;
    public bool isOnAir;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void ApplyCustomGravity()
    {
        rb2D.AddForce(Vector2.down * customGravity);
    }

    void CheckIsInFloor()
    {
        if(isOnAir)
        {
            isOnAir = Mathf.Abs(rb2D.velocity.y) > 0.1f;
        }
    }
    public void Jump()
    {
        print("juump");
        if (isOnAir) return;

        rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isOnAir = true;
    }
    private void FixedUpdate()
    {
        CheckIsInFloor();
        AddMovementInput(1, 0);
        ApplyCustomGravity();
    }
    public void AddMovementInput(float xAxisValue, float yAxisValue)
    {
        Vector2 moveDirection = new Vector2(xAxisValue, 0);

        rb2D.position = rb2D.position + moveDirection * moveSpeed * Time.deltaTime;

    }
}
