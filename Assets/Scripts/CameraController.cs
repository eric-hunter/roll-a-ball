using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset;

    //START IS CALLED BEFORE FIRST FRAME UPDATE.
    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // LATEUPDATE IS GUARANTEED TO RUN AFTER EVERY OTHER UPDATE HAS BEEN 
    // PERFORMED.
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
