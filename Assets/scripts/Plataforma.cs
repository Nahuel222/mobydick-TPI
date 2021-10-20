using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    bool tengoQueBajar = false;
    int rapidez = 3;

    void Update()
    {
        if (transform.position.y >= 14)
        {
            tengoQueBajar = true;
        }
        if (transform.position.y <= 5)
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