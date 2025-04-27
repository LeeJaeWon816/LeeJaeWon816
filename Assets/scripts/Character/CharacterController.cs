using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public float speed = 3;
    public float jumpPower = 10;
    Vector3 inputDirection = Vector3.zero;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame



    [System.Obsolete]
    void Update()
    {
        rb.velocity = new Vector2(inputDirection.x * speed, rb.velocity.y);
    }
    public void OnMoveInput(InputAction.CallbackContext callback)
    {
        inputDirection = callback.ReadValue<Vector2>();
        OnSetDirection();
    }

    private void OnSetDirection()
    {
        if (transform.localScale.x > 0 && inputDirection.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        else if (transform.localScale.x < 0 && inputDirection.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    [System.Obsolete]
    public void OnJumpInput(InputAction.CallbackContext callback)
    {
        if (callback.started)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
}
