using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasePlaceholder : MonoBehaviour
{

    public GameObject rockpipe;
    public TargetController targetController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("GameController") && targetController.Money >= 5)
        {

            this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
            targetController.Money -= 5;
            targetController.messageText.SetText("Current Money = " + targetController.Money);
            Instantiate(rockpipe);
        }
    }

}
