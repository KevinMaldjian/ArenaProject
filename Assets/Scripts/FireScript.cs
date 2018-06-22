using UnityEngine;

public class FireScript : MonoBehaviour{

    public float timer = 3f;
    public float speed = 5f;
    public float damage = 10f;


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

    private void OnTriggerEnter(Collider col)
    {
        Target target = col.transform.GetComponent<Target>();

        if (target != null)
        {
            Transform goTo = FindObjectOfType<Gun>().playerLocation;
            target.TakeDamage(damage, goTo.position);

        }
        Destroy(gameObject);
    }

}


