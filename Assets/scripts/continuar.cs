using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continuar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "teleport")
        {
            SceneManager.LoadScene("ESCAPEBALLENA");
        }
    }

}
