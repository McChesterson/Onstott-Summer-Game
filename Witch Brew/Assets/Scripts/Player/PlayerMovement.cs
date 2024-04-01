using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public InputActionReference playerMovement;
    Rigidbody2D rb;
    Vector2 move;
    public GameObject spawnPoint;

    public float moveSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = spawnPoint.transform.position;
    }

    void Update()
    {
        move = playerMovement.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.velocity = move * moveSpeed * Time.fixedDeltaTime;
    }
}