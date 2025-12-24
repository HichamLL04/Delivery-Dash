using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 200;
    [SerializeField] float moveSpeed = 7;
    [SerializeField] float regularSpeed = 7;
    [SerializeField] float boostSpeed = 15;

    [SerializeField] TMP_Text boostText;

    void Start()
    {
        boostText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
            Destroy(collision.gameObject);
            boostText.gameObject.SetActive(true);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pared")){
            moveSpeed = regularSpeed;
            boostText.gameObject.SetActive(false);
        }
    }

    void Update()
    {

        float movFrontal = 0f;
        float movLateral = 0f;

        if(Keyboard.current.wKey.isPressed)
        {
            movFrontal = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            movFrontal = -1f;
        }
        if(Keyboard.current.aKey.isPressed)
        {
            movLateral = 1f;
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            movLateral = -1f;
        }
        
        
        float moveAmount = moveSpeed * movFrontal * Time.deltaTime;
        float rotateAmount = rotateSpeed * movLateral * Time.deltaTime;

        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,rotateAmount);
        
    }

    void RotateLeft()
    {
        transform.Rotate(0, 0, -rotateSpeed);
    }
}
