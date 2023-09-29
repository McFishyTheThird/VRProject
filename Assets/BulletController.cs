using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField]
    float force = 500;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);

        }
    }
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * force);
    }
}
