using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float speed = 8.0f;



    [SerializeField]
    private float damage = 4.0f;



    //Destroy bullet trigger events. One for player one if the bullet hits the bottom barrier.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BottomBarrier")
        {
            //Debug.Log("Destroyed bullet!");
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("Destroyed bullet!");
            Destroy(gameObject);

        }

    }

    // Update is called once per frame
    void Update()
    {
        //Makes the bullet move down the screen at the speed set
        float moveY = speed * Time.deltaTime;
        transform.Translate(new Vector3(0.0f, -moveY, 0.0f));
    }
}
