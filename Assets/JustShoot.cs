using UnityEngine;
using UnityEngine.Networking;

public class JustShoot : NetworkBehaviour
{
    public Transform emitZone;
    public GameObject bullet;
    public Transform playerLocation;
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    GameObject myBullet;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            CmdShoot();
        }
    }

    [Command]
    public void CmdShoot()
    {
       myBullet = Instantiate(bullet, emitZone.position, playerLocation.rotation);
       NetworkServer.Spawn(myBullet);
    }

}
