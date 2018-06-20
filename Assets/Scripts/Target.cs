using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 10f; 



    public void TakeDamage(float amount, Vector3 hitBy)
    {
        Debug.Log("GettingPulled");

        float step = health * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, hitBy, step);
    }
}
