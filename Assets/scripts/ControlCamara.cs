using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public GameObject Jugador;
    public float rotateSpeed = 5;
    public Vector3 offset;

    void Start()
    {
        offset = Jugador.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        Jugador.transform.Rotate(0, horizontal, 0);
        float desiredAngle = Jugador.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = Jugador.transform.position - (rotation * offset);

        transform.LookAt(Jugador.transform);
    }
}
