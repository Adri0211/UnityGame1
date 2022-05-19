using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{

    public GameObject camara;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        if (z != 0)
        {
            if (z < 0)
            {
                //transform.Rotate(transform.up.normalized, camara.transform.rotation.y - transform.rotation.y);
            }
            if (z > 0)
            {

            }
        }

    }
}
