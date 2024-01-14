using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
    public float speed = 10;
    public float jumpDist = 50000000.0f;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Player.Buttons.performed += ctx => Jump();
        controls.Player.Move.performed += context => move = context.ReadValue<Vector2>();
        controls.Player.Move.canceled += context => move = Vector2.zero;
    }

    void Jump()
    {
        Vector3 movement = new Vector3(0.0f, jumpDist, 0.0f);// * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }


    void SendMessage(Vector2 coordinates)
    {
        Debug.Log("Co-ordinates = " + coordinates);
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(move.x, 0.0f, move.y) * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
