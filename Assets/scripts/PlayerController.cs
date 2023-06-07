using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 1.5f;
    private Rigidbody rb;
    public float jumpForce = 8f;
    private bool isJumping = false;
    private int score; 
    public TMP_Text scoreText;




    // Start is called before the first frame update
    void Start()
    {
        score=0; 
        UpdateScore();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
        float moveInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotationInput * rotationSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isJumping = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            UpdateScore();

            Destroy(other.gameObject);
        }
    }

    private void UpdateScore()
    {
        //The variable that represents the text and its text string. "The text" + the variable of the points 
        scoreText.text = "Coins: " + score;
    }
}
