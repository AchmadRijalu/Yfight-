using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShrink : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;

    private Collider2D collider;
    public GameObject Meteor;
    [SerializeField] private AudioClip Shrink;
    void Start()
    {
        collider = GetComponent<Collider2D>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            SoundManager.instance.PlaySound(Shrink);
            collider.isTrigger = true;
            Destroy(gameObject); 
            GameObject playerGameObj = GameObject.FindWithTag("Player2");
            PlayerController controller = playerGameObj.GetComponentInChildren<PlayerController>();

            controller.transform.localScale *= 0.5f;

            Debug.Log("Shrink player 2");
        }
        if (collision.gameObject.tag == "Player1")
        {
            SoundManager.instance.PlaySound(Shrink);
            collider.isTrigger = true;
            Destroy(gameObject);
            GameObject playerGameObj = GameObject.FindWithTag("Player1");
            PlayerController controller = playerGameObj.GetComponentInChildren<PlayerController>();

            controller.transform.localScale *= 0.5f;

            Debug.Log("Shrink player 1");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            SoundManager.instance.PlaySound(Shrink);
            collider.isTrigger = true;
            Destroy(gameObject);
            GameObject playerGameObj = GameObject.FindWithTag("Player2");
            PlayerController controller = playerGameObj.GetComponentInChildren<PlayerController>();

            controller.transform.localScale *= 0.5f;

            Debug.Log("Shrink player 2");
        }
        if (collision.gameObject.tag == "Player1")
        {
            SoundManager.instance.PlaySound(Shrink);
            collider.isTrigger = true;
            Destroy(gameObject);
            GameObject playerGameObj = GameObject.FindWithTag("Player1");
            PlayerController controller = playerGameObj.GetComponentInChildren<PlayerController>();

            controller.transform.localScale *= 0.5f;

            Debug.Log("Shrink player 1");
        }
        collider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
