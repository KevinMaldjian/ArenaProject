using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    //private Transform player;
    public Transform blueSpawn;
    public Transform redSpawn;

    public void spawnTime(int spawnSide, Transform player)
    {
        if(spawnSide == 1)
        {
            player.transform.position = blueSpawn.transform.position;
        }
        else
        {
            player.transform.position = redSpawn.transform.position;
        }
    }
}
