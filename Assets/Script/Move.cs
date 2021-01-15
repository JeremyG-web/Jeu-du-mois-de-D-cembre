using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [SerializeField]
    private float rotateSpeed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make your plane orientated toward up and down : "Vertical" input axis and Vector3.forward
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Rotate(Vector3.forward * (-rotateSpeed * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Rotate(Vector3.forward * (rotateSpeed * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Rotate(Vector3.right * (-rotateSpeed * Time.deltaTime));
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Rotate(Vector3.right * (rotateSpeed * Time.deltaTime));
        }
    }
}
