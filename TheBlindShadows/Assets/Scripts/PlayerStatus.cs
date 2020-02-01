using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OOOOOO");
        if (collision.gameObject.tag == "Ghost" )//|| collision.gameObject.CompareTag("DarkArea"))
        {
           Debug.Log("Mario Killed"); 
                 this.gameObject.GetComponent<PlayerController>().enabled = false;
            GameObject.Destroy(this.gameObject);
                
        }
       
    } 
}
