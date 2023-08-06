using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TerrainUtils;

public class TargetController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            yield return new WaitForSeconds(1);
            this.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
    }

    
}