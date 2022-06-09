using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletioninsertionmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
  void OnMouseDown() {
            destroy(gameobject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //destroy object on keydown
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
        //detecting collisionEnter
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }
        //moving gameobject using if condition and velocity
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        } 
        

        //if key pressed Adding force to the object
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*500);
        }
        if (Input.GetKeyDown(KeyCode.w))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward*500);
        }
        if (Input.GetKeyDown(KeyCode.s))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back*500);
        }

    }
}
