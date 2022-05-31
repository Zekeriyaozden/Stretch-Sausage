using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageController : MonoBehaviour
{
    public float force;
    private Vector3 vLast;
    private Vector3 direction;
    void Start()
    {
        vLast = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (vLast != gameObject.transform.position)
        {
            direction = gameObject.transform.position - vLast;
            vLast = gameObject.transform.position;
            gameObject.transform.eulerAngles = direction;
        }*/
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.left * force);
            Debug.Log("Right");
        }
    }
}
