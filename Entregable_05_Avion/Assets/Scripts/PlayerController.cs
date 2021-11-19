using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10f;
    private float verticalInput;
    private float turnSpeed = 20;
    private float zMax = 450f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z = zMax)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}
