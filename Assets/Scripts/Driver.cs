using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.05f;
    void Start()
    {
     
    }

    void Update()
    {

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            RotateLeft();
        }

        transform.Rotate(0,0,rotateSpeed);
        transform.Translate(0,moveSpeed,0);
    }

    void RotateLeft()
    {
        transform.Rotate(0, 0, -rotateSpeed);
    }
}
