using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 200.0f;
    [SerializeField] float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float acceleration = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, acceleration, 0);
    }
}
