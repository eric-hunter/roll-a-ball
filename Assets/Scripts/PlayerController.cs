using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Text CountText;
    public Text WinText;

    private Rigidbody rb;
    private int count;

    //CALLED BEFORE THE FIRST FRAME IS RENDERED.
    public void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();
        WinText.text = "";
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

        rb.AddForce(movement * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    private void SetCountText()
    {
        CountText.text = "Count: " + count;
        if (count >= 8)
        {
            WinText.text = "YOU WIN!";
        }
    }

}
