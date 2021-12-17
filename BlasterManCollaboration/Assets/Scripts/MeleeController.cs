using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
   int health = 1;
    [SerializeField] private float moveSpeed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int health = 2;


        if (collision.gameObject.tag == "playerLaser")
        {
            health -= 1;

            //what ever else the code needs to do
        }

        if (collision.gameObject.tag == "Player")
        {
           
            health -= 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.World);

        if (health <= 0)
        {
            Destroy(this);
        }
    }
}
