using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    bool tengoQueBajar = false;
    int rapidez = 25;

    void Update()
    {
        if (transform.position.x >= 0.2)
        {
            tengoQueBajar = true;
        }
        if (transform.position.x <= 161.6)
        {
            tengoQueBajar = false;
        }

        if (tengoQueBajar)
        {
            Bajar();
        }
        else
        {
            Subir();
        }

    }

    void Subir()
    {
        transform.position += transform.up * rapidez * Time.deltaTime;
    }

    void Bajar()
    {
        transform.position -= transform.up * rapidez * Time.deltaTime;
    }
}