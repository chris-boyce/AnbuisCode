
using UnityEngine;

public class JE_Gun : MonoBehaviour

{

	public float damage = 10f;
	public float range = 1000f;
	public float fireRate = 15f;

	public int maxAmmo = 10;
	private int currentAmmo;
	public float reloadTime = 1f;


	public Camera fpsCam;

	private float nextTimeToFire = 0f;

	//------------------------------------------------

	void Start ()
	{
		currentAmmo = maxAmmo;
	}


    // Update is called once per frame------------------------
    void Update()
    {

		if (currentAmmo <= 0)
		{
			Reload();
			return;
		}



        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)        // when the player presses left mouse button shoot
		{
			nextTimeToFire = Time.time + 1f / fireRate;
			Shoot();
		}
    }
	//---------------------------------------------------------
	void Reload ()
	{
		Debug.Log ("Reloading...");
		currentAmmo = maxAmmo;

	}

	//-------------------------------------------------------

	void Shoot ()
	{

		currentAmmo--;
		
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit,  range))
		{
			Debug.Log(hit.transform.name);

			JE_Target target = hit.transform.GetComponent<JE_Target>();
			if (target != null)
			{
				target.TakeDamage(damage);
			}
		}
	}
}
