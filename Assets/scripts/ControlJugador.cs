using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public Camera camaraEnPrimeraPersona;
    public GameObject proyectil;
    public float rapidezDesplazamiento = 10.0f;
    public float salto;
    private bool enElSuelo = true;
    public int maxSaltos =2;
    public int saltoActual = 0;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && (enElSuelo || maxSaltos > saltoActual))
        {

            rb.velocity = new Vector3(0f, salto, 0f * Time.deltaTime);
            rb.AddForce(Vector3.up * salto, ForceMode.Impulse);
            enElSuelo = false;
            saltoActual++;

        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = camaraEnPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    RaycastHit hit;

    GameObject pro;
    pro = Instantiate(proyectil, rayo.origin, transform.rotation);

    Rigidbody rb = pro.GetComponent<Rigidbody>();
    rb.AddForce(camaraEnPrimeraPersona.transform.forward* 10, ForceMode.Impulse);
            Destroy(pro,3);

            Destroy(pro, 3);


            if (Physics.Raycast(rayo, out hit) == true && hit.distance< 30)
            {
                Debug.Log("Le di a " + hit.collider.name);

                if (hit.collider.name.Substring(0, 3) == "Bot")
                {
                    GameObject objetoTocado = GameObject.Find(hit.transform.name);
    ControlBot scriptObjetoTocado = (ControlBot)objetoTocado.GetComponent(typeof(ControlBot));

                    if (scriptObjetoTocado != null)
                    {
                        scriptObjetoTocado.recibirDaño();

                    }

                }

            }

        }
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);
    }
}
    private void OnCollisionEnter(Collision collision)
    {
        enElSuelo = true;
        saltoActual = 0;
    }
}
