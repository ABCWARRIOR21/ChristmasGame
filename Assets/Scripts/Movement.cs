using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public Animator Santa;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var Movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(Movement, 0, 0) * Time.deltaTime * MovementSpeed;

        Santa.SetFloat("Speed", Mathf.Abs(Movement));

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

        }
    }

}