using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 0.8f;
    [SerializeField] float moveSpeed = 0.05f;
    void Start()
    {
     
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
