using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanController : MonoBehaviour
{

    [SerializeField]
    private int health = 1;

    [SerializeField] private float moveSpeed = 1.0f;

    public GameObject egoDrop;
    public GameObject energy;
    public float randomDrop;

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
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.World);

        if (health <= 0)
        {
            randomDrop = Random.Range(0, 2);
            Debug.Log(randomDrop);
            if (randomDrop < 1)
            {
                Instantiate(egoDrop, transform.position, transform.rotation);
            }
            else
            {
                Instantiate(energy, transform.position, transform.rotation);
            }
            Destroy(this.gameObject);
        }

    }


}