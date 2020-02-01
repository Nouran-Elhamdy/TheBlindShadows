using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0;
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private Animator animator = null;
    [SerializeField] private GameObject lamp = null;
    [SerializeField] private int timer = 0;
    [SerializeField] private AudioSource audioSource = null;

    Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        audioSource.Play();
       
    }

  
    void Update()
    {
        PlayerMovements();
    }

    private void PlayerMovements()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("destroy pick up candle");
        if (collision.CompareTag("Candle"))
        {
          Destroy(collision.gameObject);
          lamp.SetActive(true);
        }
        StartCoroutine(HideLight());

    }
    IEnumerator HideLight()
    {
        yield return new WaitForSeconds(timer);
        lamp.SetActive(false);

    }
}
