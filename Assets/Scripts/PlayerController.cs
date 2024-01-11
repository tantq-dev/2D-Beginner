using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{


    public InputAction MoveAction;
    void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        Vector2 inputValue = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + inputValue * 3.0f*Time.deltaTime;

        transform.position = position;
    }
}
