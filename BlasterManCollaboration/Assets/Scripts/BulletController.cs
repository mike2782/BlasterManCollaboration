using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField]
    private int health = 1;

    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float damage = 4.0f;

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
        float moveX = speed * Time.deltaTime;
        transform.Translate(new Vector3(0.0f, -moveX, 0.0f));

        if (health <= 0)
        {
            Object.DestroyImmediate(this);
        }
    }
}

