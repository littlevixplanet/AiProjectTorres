using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    /*float mass = 10;
    float force = 300;
    float acceleration;
    float speedZ;
    float speedY;
    float gAccel;
    float gravity = -1.8f;*/
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /*void LateUpdate()
    {
        acceleration = force / mass;
        speedZ += acceleration * Time.deltaTime;
        this.transform.Translate(0,speedY, speedZ);
        gAccel = gravity / mass;
        speedY += gAccel * Time.deltaTime;
        force = 0;
    }*/
}
