using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    public int hp;
    public GameObject jugador;
    public int rapidez;

    void Start()
    {
        hp = 100;
        
    }


    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp <= 0)
        {
            Desaparecer();
        }


    }

    private void Desaparecer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {

            recibirDaño();

        }


    }
            

        private void Update()
        {
            transform.LookAt(jugador.transform);
            transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
        }
    }