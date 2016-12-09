using UnityEngine;
using System.Collections;

public class destroyContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;


	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemy")
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Boundary")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
		}
			
	}
}