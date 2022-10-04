using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
     Transform playerBody;
    GameObject gun;
    float xRotation = 0;
    LoadScene scene;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        scene = GameObject.Find("GameManager").GetComponent<LoadScene>();
    }

    // Update is called once per frame
    void Update()
    {
        playerBody = scene.clone.transform;
        gun = scene.clone1;
        gun.transform.SetParent(gameObject.transform);
        transform.SetParent(playerBody );
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
