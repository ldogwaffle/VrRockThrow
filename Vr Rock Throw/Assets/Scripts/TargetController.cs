using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TerrainUtils;
using TMPro;

public class TargetController : MonoBehaviour
{
    
    public TMP_Text messageText;
    public int Money = 0;
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
            Money = Money + 1;
            messageText.SetText("Current Money = " + Money);
            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
            yield return new WaitForSeconds(1);
            this.gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        }
    }

    
}