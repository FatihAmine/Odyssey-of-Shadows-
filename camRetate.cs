using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRetate : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  
        Cursor.visible = false;
    }
    public Vector2 turn;
    public float sensitivity = .5f;
    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        transform.localRotation = Quaternion.Euler(turn.y, -turn.x, 0);
    }
}
