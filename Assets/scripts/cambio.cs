using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ballena")
        {
            SceneManager.LoadScene("menu");
        }
    }

}
