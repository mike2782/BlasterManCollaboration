using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    float speed;
    float shootSpeed;
    GameObject bullet;
    float playerLives = 3;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            //Debug.Log("Destroyed bullet! and hit player");           
            playerLives--;
            Debug.Log(playerLives);
        }
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLives <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Game over!");
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool shootInput = Input.GetKeyDown("space");

        //Calculate movement vector
        Vector2 moveVector;

        Vector2 horizontal = Vector2.right * horizontalInput;
        Vector2 vertical = Vector2.up * verticalInput;
        moveVector = (horizontal + vertical) * speed * Time.deltaTime;

        //Apply movement
        
        transform.Translate(new Vector3(moveVector.x, moveVector.y, 0.0f));

        //Apply shooting

        while (shootInput)
        {
            Instantiate(bullet);
        }
    }
}
