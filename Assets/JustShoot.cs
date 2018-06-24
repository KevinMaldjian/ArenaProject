using UnityEngine;
using UnityEngine.Networking;

public class JustShoot : NetworkBehaviour
{

    public Transform emitZone;
    public GameObject bullet;
    GameObject myBullet; 

    [Command]
    public void CmdShoot(Quaternion angle )
    {
        
        myBullet = Instantiate(bullet, emitZone.position, angle);
        NetworkServer.Spawn(myBullet);
    }

}
