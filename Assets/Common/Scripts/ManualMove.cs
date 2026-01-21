using UnityEngine;
using UnityEngine.InputSystem;

public class ManualMove : MonoBehaviour
{
    [SerializeField] bool ASDWControls = true;
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 90.0f;

    void Start()
    {
    }

    void Update()
    {
        float direction = 0.0f;
        float directionSide = 0.0f;
        if (ASDWControls)
        {
            if (Keyboard.current.wKey.isPressed) direction = +1.0f;
            if (Keyboard.current.sKey.isPressed) direction = -1.0f;
            if (Keyboard.current.aKey.isPressed) directionSide = -1.0f;
            if (Keyboard.current.dKey.isPressed) directionSide = +1.0f;
        }
        else
        {
            if (Keyboard.current.upArrowKey.isPressed) direction = +1.0f;
            if (Keyboard.current.downArrowKey.isPressed) direction = -1.0f;
            if (Keyboard.current.leftArrowKey.isPressed) directionSide = -1.0f;
            if (Keyboard.current.rightArrowKey.isPressed) directionSide = +1.0f;
        }
        //transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);
        Vector3 moveDir = (transform.forward * direction + transform.right * directionSide).normalized;
        transform.Translate(moveDir * speed * Time.deltaTime, Space.World);

        float rotation = 0.0f;
        if (ASDWControls)
        {
            if (Keyboard.current.qKey.isPressed) rotation = -1.0f;
            if (Keyboard.current.eKey.isPressed) rotation = +1.0f;
        }
        else
        {
            if (Keyboard.current.pageUpKey.isPressed) rotation = -1.0f;
            if (Keyboard.current.pageDownKey.isPressed) rotation = +1.0f;
        }

        transform.Rotate(Vector3.up * rotation * rotationSpeed * Time.deltaTime);
    }
}
