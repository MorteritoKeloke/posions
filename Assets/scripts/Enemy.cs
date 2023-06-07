using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyspeed;

    private Rigidbody _rigidbody;
    private GameObject player; 
    private PlayerController playerController;


    // Start is called before the first frame update
    private void Awake()
    {
     _rigidbody = GetComponent<Rigidbody>();   
    }

    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized; // Normalizado para que la distancia entre uno y el otro siempre sea 1.
        _rigidbody.AddForce(direction * enemyspeed); //con la direccion normalidaza siempre ira a velocidad constante porque la distancia entre el enemigo y player siempre es 1. Si no lo tuviera, como mas cerca mas lento se mueve el enemigo y como mas lejos mas sprints dara.
    }

}
