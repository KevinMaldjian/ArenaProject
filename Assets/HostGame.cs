using UnityEngine;
using UnityEngine.Networking;

public class HostGame : MonoBehaviour {

    [SerializeField]
    private uint roomSize = 8; 
    
    private string roomName;
    private NetworkManager networkManager; 

    private void Start()
    {
        networkManager = NetworkManager.singleton;  
    }


    public void SetRoomName(string _name)
    {
        roomName = _name;
    }

    public void CreateRoom()
    {
        if(roomName != "" && roomName != null)
        {
            Debug.Log("Creating room: " + roomName + " with room for " + roomSize + " players");
            
        }
    }

}
