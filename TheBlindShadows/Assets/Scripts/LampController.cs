using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{

    [SerializeField]
    GameObject FlashElectrcity;
    [SerializeField] private GameObject turnedOffLight = null;
    [SerializeField] private GameObject turnedOnLight = null;
    // Start is called before the first frame update
    void Start()
    {
        FlashElectrcity.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.Q)) 
        {
            turnedOnLight.gameObject.SetActive(false);
            turnedOffLight.gameObject.SetActive(true);
            StartCoroutine(TurnOnFlashElectrcity());
            Debug.Log("hii turn on");
        }
    }

    IEnumerator TurnOnFlashElectrcity()
    {

        for (var n = 0; n < 4; n++)
        {
            FlashElectrcity.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(0.1f);
            FlashElectrcity.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(0.1f);
        }

        FlashElectrcity.GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
