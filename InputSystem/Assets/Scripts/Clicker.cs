using UnityEngine;
using TMPro;


public class Clicker : MonoBehaviour
{
    //public float jumpDist = 50000000.0f;
    public TMP_Text messageText;
    public int jumpCounter = 0;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Jump();
        }
    }

    void Jump()
    {
        jumpCounter++;
        messageText.SetText("Click " + jumpCounter);

        //Vector3 movement = new Vector3(0.0f, jumpDist, 0.0f) * Time.deltaTime;
        //transform.Translate(movement, Space.World);
    }
}