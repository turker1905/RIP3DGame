using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 100f;
    [SerializeField] float _angle = 80f;

    float rotY = 0;
    float rotX = 0;

    private void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    private void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotY += mouseX * _mouseSensitivity * Time.deltaTime;
        rotX += mouseY * _mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -10, 10);
        rotY = Mathf.Clamp(rotY, -10, 10);
        Quaternion LocalRotation = Quaternion.Euler(rotX, rotY, 0f);
        transform.rotation = LocalRotation;

    }



}
