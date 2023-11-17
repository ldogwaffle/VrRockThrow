using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallController : MonoBehaviour
{
    public GameObject ballReset;
    public GameObject breakParticle;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = ballReset.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Instantiate(breakParticle, transform.position, Quaternion.identity);
            Instantiate(this.gameObject);
            Destroy(this.gameObject);
            
        }
    }
}