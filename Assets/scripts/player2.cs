using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public float jumpForce = 5f; // Fuerza de salto del jugador
    public float gravity = 9.81f; // Gravedad aplicada al jugador

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        groundedPlayer = controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // Movimiento horizontal
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * speed * Time.deltaTime);

        // Salto
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        // Aplicar gravedad
        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
