using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = .1f;
    [SerializeField] float speed = .01f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed;
        float acceleration = Input.GetAxis("Vertical") * speed;

        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, acceleration, 0);
    }
}
