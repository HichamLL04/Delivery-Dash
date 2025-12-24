using UnityEngine;

public class Delivery : MonoBehaviour
{


    bool hasPackage = false;
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

        if (collision.CompareTag("Cliente") && hasPackage)
        {
            Debug.Log("Cliente " + collision.gameObject.name + " ha recibido el paquete.");
            GetComponent<ParticleSystem>().Stop();

            hasPackage = false;
        }
    }
}