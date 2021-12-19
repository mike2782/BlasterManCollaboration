using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
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
            Destroy(this.gameObject);
        }

    }


}




