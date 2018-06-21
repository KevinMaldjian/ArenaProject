using UnityEngine;

public class Gun : MonoBehaviour {

    public Transform emitZone;
    public GameObject bullet;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f; 

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, emitZone.position, transform.rotation);
    }
	

}
