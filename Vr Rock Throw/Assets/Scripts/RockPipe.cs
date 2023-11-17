using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPipe : MonoBehaviour
{
    public GameObject rock;
    public GameObject exitpoint;
    public GameObject smokeParticle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            GameObject rock = collision.gameObject;
            rock.transform.position = exitpoint.transform.position;
            Instantiate(smokeParticle, exitpoint.transform.position, Quaternion.identity);
            Rigidbody rockRigidbody = rock.GetComponent<Rigidbody>();
            if (rockRigidbody != null)
            {
                float forceMagnitude = 10f; // Adjust the force value as needed
                Vector3 forceDirection = Vector3.forward; // Assuming z direction
                rockRigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
            }
        }
    }
}
