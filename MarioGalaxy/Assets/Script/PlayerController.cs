using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject[] planets;
    public GameObject camara;
    public int speed;
    public int jumpH;

    private Rigidbody rb;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        //transform.Rotate(transform.up, camara.transform.rotation.y - transform.rotation.y);

        transform.Translate(x, 0f, z, camara.transform);

        Physics.gravity = planets[0].transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(transform.up, -Physics.gravity) * transform.rotation;

        if (onGround)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(transform.up*jumpH*100);
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
        }
    }
}
