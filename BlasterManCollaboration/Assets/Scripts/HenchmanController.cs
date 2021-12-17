using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;

    int health = 1;
    // Start is called before the first frame update
    void Start()
    {
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        


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

        if ( health <= 0)
        {
            Destroy(this);
        }

}
       
    
}

