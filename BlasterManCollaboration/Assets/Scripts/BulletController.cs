

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField]
    private int health = 1;

    [SerializeField] private float moveSpeed = 1.0f;

    

    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.tag == "LaserEyes")
        {
            health -= 1;

            //what ever else the code needs to do
        }

        if (collision.gameObject.tag == "Player")
        {
            health -= 1;
        }


        if (health <= 0)
        {

            
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.World);
    

    
    }

    }




