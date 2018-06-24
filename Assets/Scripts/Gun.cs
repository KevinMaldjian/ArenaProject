using UnityEngine;
using UnityEngine.Networking;

public class Gun : MonoBehaviour
{

    public Transform emitZone;
    public GameObject bullet;
    public Transform playerLocation; 
    public float fireRate = 15f;
    private float nextTimeToFire = 0f; 

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            FindObjectOfType<JustShoot>().CmdShoot(transform.rotation); 
        }
    }


	

}
