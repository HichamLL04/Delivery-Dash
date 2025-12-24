using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        // Ahora se usa "other" no "collision" a diferencia del video
        if (other.CompareTag("Paquete") && !hasPackage)
        {
            Debug.Log("Paquete " + other.gameObject.name + " recogido.");
            hasPackage = true;
        }

        if (other.CompareTag("Cliente") && hasPackage)
        {
            Debug.Log("Cliente " + other.gameObject.name + " ha recibido el paquete.");
            hasPackage = false;
        }
    }
}