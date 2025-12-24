using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Ahora se usa "other" no "collision" a diferencia del video
        if (other.CompareTag("Paquete"))
        {
            Debug.Log("Paquete " + other.gameObject.name + " recogido.");
        }

        if (other.CompareTag("Cliente"))
        {
            Debug.Log("Cliente " + other.gameObject.name + " ha recibido el paquete.");
        }
    }
}