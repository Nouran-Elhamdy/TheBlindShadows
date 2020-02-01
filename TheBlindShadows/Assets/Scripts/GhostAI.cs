using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAI : MonoBehaviour
{

     Transform playerCharacterTran;
    [SerializeField]
    float ghostSpeed;
    [SerializeField]
    float frequency = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
       

        playerCharacterTran = GameObject.FindGameObjectWithTag("Player").transform;
        if (playerCharacterTran)
        {
            //nothing
        }
        else
        {
            Debug.Log("Can't found player");
        }
         

    }

    // Update is called once per frame
    void Update()
    {


        CheckDistance();
    }
    private void FixedUpdate()
    {
        
    }
    void CheckDistance()
    {
        if (playerCharacterTran != null)
        if(Vector2.Distance(playerCharacterTran.position,transform.position) <= 15.0f)
        {
             Debug.Log("HERE");
                //transform.position = Vector2.Lerp()
                transform.position = Vector2.MoveTowards(transform.position,
                    playerCharacterTran.position
                    , ghostSpeed * Time.deltaTime); 
                transform.position = transform.position +(transform.up * Mathf.Sin(Time.time * frequency) * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("CandleLight"))
        {
            Debug.Log(this.name + " Died");
            Destroy(this.gameObject);
        }
    }
     
  
}
