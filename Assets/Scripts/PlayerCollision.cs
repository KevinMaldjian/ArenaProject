using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private void OnTriggerEnter(Collider collisionInfo)
    {

        Debug.Log("Something");
        if (collisionInfo.tag == "BlueGoal")
        {
            FindObjectOfType<ScoreKeeper>().goalScored(1);
            FindObjectOfType<Respawn>().spawnTime(1, movement.transform);
        }
    }

}
