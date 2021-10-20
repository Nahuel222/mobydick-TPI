using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueFinal : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")==true)
        {
        collision.transform.position = spawn.position;
        }
    }
}