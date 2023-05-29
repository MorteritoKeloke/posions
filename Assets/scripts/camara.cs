using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target; // Referencia al transform del jugador
    public float distance = 5f; // Distancia entre la cámara y el jugador
    public float height = 3f; // Altura de la cámara
    public float smoothSpeed = 10f; // Velocidad de suavizado de la transición de la cámara

    private Vector3 offset; // Offset inicial entre la cámara y el jugador

    private void Start()
    {
        offset = transform.position - target.position; // Calcula el offset inicial
    }

    private void LateUpdate()
    {
        // Calcula la posición de destino de la cámara
        Vector3 targetPosition = target.position + offset + target.forward * distance + Vector3.up * height;

        // Realiza una transición suave hacia la posición de destino
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

        // Mira hacia el jugador
        transform.LookAt(target);
    }
}
