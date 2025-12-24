using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    bool hasDeliveredC1 = false;
    bool hasDeliveredC2 = false;
    bool hasDeliveredC3 = false;
    bool hasDeliveredC4 = false;

    [SerializeField] float time = 0.5f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Paquete") && !hasPackage)
        {
            Debug.Log("Paquete " + collision.gameObject.name + " recogido.");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, time);
        }

        if (collision.CompareTag("Cliente1") && hasPackage && !hasDeliveredC1)
            {
                Debug.Log("Cliente1 " + collision.gameObject.name + " ha recibido el paquete.");
                GetComponent<ParticleSystem>().Stop();
                hasPackage = false;
                hasDeliveredC1 = true;
            }
        else if (collision.CompareTag("Cliente2") && hasPackage && !hasDeliveredC2)
            {
                Debug.Log("Cliente2 " + collision.gameObject.name + " ha recibido el paquete.");
                GetComponent<ParticleSystem>().Stop();
                hasPackage = false;
                hasDeliveredC2 = true;
            }
        else if (collision.CompareTag("Cliente3") && hasPackage && !hasDeliveredC3)
        {
            Debug.Log("Cliente3 " + collision.gameObject.name + " ha recibido el paquete.");
            GetComponent<ParticleSystem>().Stop();
            hasPackage = false;
            hasDeliveredC3 = true;
        }
        else if (collision.CompareTag("Cliente4") && hasPackage && !hasDeliveredC4)
            {
                Debug.Log("Cliente4 " + collision.gameObject.name + " ha recibido el paquete.");
                GetComponent<ParticleSystem>().Stop();
                hasPackage = false;
                hasDeliveredC4 = true;
            }

    }
}