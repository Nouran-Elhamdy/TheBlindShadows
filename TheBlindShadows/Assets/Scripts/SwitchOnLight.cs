using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnLight : MonoBehaviour
{
    [SerializeField] private GameObject turnedOffLight = null;
    [SerializeField] private GameObject turnedOnLight = null;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Q))
            {
                turnedOffLight.gameObject.SetActive(false);
                turnedOnLight.gameObject.SetActive(true);
            }
        }

    }
}
