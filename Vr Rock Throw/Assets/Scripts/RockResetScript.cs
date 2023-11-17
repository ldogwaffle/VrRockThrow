using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockResetButton : MonoBehaviour
{

    public GameObject ballReset;
    public GameObject rock;
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
            rock.transform.position = ballReset.transform.position;
        }
    }
}
