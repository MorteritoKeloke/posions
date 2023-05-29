using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del personaje
    public float jumpForce = 5f; // Fuerza del salto
    public float runSpeedMultiplier = 1.5f; // Multiplicador de velocidad al correr

    private bool isJumping = false; // Indica si el personaje está saltando
    private bool isRunning = false; // Indica si el personaje está corriendo

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Movimiento horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        // Movimiento vertical
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Aplicar multiplicador de velocidad al correr
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement *= runSpeedMultiplier;
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        // Mover al personaje
        rb.velocity = new Vector3(movement.x * moveSpeed, rb.velocity.y, movement.z * moveSpeed);

        // Saltar
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        // Dar golpes
        if (Input.GetMouseButtonDown(1))
        {
            // Lógica para dar golpes
            Attack();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si el personaje ha aterrizado después de un salto
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void Attack()
    {
        // Lógica para el ataque
    }
}
