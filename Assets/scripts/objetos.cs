using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class objetos : MonoBehaviour
{

	public float speed;
	private Rigidbody rbody;

	void Start()
	{

		speed = 15f;
		rbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		float x = Random.Range(-200, 200);
		float z = Random.Range(-200, 200);

		//transform.Translate (speed*Input.GetAxis ("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis ("Vertical")*Time.deltaTime);
		rbody.AddForce(speed * x * Time.deltaTime, 0f, speed * z * Time.deltaTime);
	}
}