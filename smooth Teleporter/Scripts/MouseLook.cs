using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    public float mouseSenstivity = 100f;

    public Transform playerBody;

    public float xRoatation = 0f;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSenstivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSenstivity * Time.deltaTime;

        xRoatation -= mouseY;
        xRoatation = Mathf.Clamp(xRoatation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRoatation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
