using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float thrust;
    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //CALLED BEFORE RENDERING A FRAME.
    private void Update()
    {

    }

    //CALLED JUST BEFORE ANY PHYSICS CALCULATIONS
    //THIS IS WHERE PHSYICS GO.
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement);
    }

}
