using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform target; // Referencia al transform del jugador
    public float distance = 5f; // Distancia entre la c�mara y el jugador
    public float height = 3f; // Altura de la c�mara
    public float smoothSpeed = 10f; // Velocidad de suavizado de la transici�n de la c�mara

    private Vector3 offset; // Offset inicial entre la c�mara y el jugador

    private void Start()
    {
        offset = transform.position - target.position; // Calcula el offset inicial
    }

    private void LateUpdate()
    {
        // Calcula la posici�n de destino de la c�mara
        Vector3 targetPosition = target.position + offset + target.forward * distance + Vector3.up * height;

        // Realiza una transici�n suave hacia la posici�n de destino
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

        // Mira hacia el jugador
        transform.LookAt(target);
    }
}
