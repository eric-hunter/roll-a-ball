using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        //by multiplying the v3 by deltaTime, we get smooth animation on frame
        //updates.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
