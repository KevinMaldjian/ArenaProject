using UnityEngine;

public class FireScript : MonoBehaviour{

    public float timer = 3f;
    public float speed = 5f; 


    void Start()
    {
        Invoke("Die", timer);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void Die()
    {
        Destroy(gameObject);
    }



}


