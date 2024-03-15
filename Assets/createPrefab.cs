using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPrefab : MonoBehaviour
{
    public GameObject fencePrefab; // Referencia al Prefab de la valla
    public float spacing = 1.5f; // Espacio entre las vallas

    void Start()
    {
        // Instancia la valla en la posición (0, 0, 0)
        Instantiate(fencePrefab, Vector3.zero, Quaternion.identity);

        // Crea una línea de vallas con el espaciado deseado
        for (int i = 1; i < 10; i++) // Comenzamos desde 1 para evitar duplicar la primera valla
        {
            Vector3 spawnPosition = new Vector3(i * spacing, 0, 0);
            Quaternion rotation = Quaternion.Euler(0, 90, 0); // Rota 90 grados en el eje Y
            Instantiate(fencePrefab, spawnPosition, rotation);
        }
    }
}
