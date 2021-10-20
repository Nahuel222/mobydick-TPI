using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private GameObject jugador;
    public int rapidez;

    void Start()
    {
        jugador = GameObject.Find("player");
    }

    private void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
    }
}