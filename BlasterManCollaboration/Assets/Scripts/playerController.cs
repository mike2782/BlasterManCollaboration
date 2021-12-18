using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float shootTimer = 0.5f;

    [SerializeField]
    GameObject blastSkillObjects;

    [SerializeField]
    GameObject laserEyes;

    [SerializeField]
    GameObject invisibleBullet;

    GameObject currentLaserEyes;

    float egoMeter = 100;
    float energyMeter = 100;
    float chipsOnShoulder = 3;   

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            egoMeter -= 10;           
            Debug.Log("10 damage from bullet");
        }

        if (collision.gameObject.tag == "Enemy")
        {
            egoMeter -= 20;
            Debug.Log("20 damage from bullet");
        }
    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        //Starts a countdown until fire is enabled again
        shootTimer -= Time.deltaTime;
        
        //If space is pressed, we creat a laserEyes object and set it to the parents position
        if(Input.GetKeyDown("space") == true )
        {
            if (shootTimer <= 0)
            {
                currentLaserEyes = Instantiate(laserEyes, transform.position, transform.rotation);
                currentLaserEyes.transform.parent = transform;
                //Resets shoot timer each time fired
                shootTimer = 0.5f;
            }
        }

        //This is the lives of the player and will destroy the player object is hits 0 or below
        if(chipsOnShoulder <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Game over!");
        }
       
        //Control variables
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        bool blastInput = Input.GetKeyDown("e");
        bool shieldInput = Input.GetKeyDown("q");
        


        //Calculate movement vector
        Vector2 moveVector;

        Vector2 horizontal = Vector2.right * horizontalInput;
        Vector2 vertical = Vector2.up * verticalInput;
        moveVector = (horizontal + vertical) * speed * Time.deltaTime;
        //moveVector = moveVector.normalized * Time.deltaTime;

        //Apply movement
        transform.Translate(new Vector3(moveVector.x, moveVector.y, 0.0f));
        

        //This reduces the lives (chips) by 1 if the ego meter (health) reached 0 or less and also if chips reach 3, game over
        if(egoMeter <= 0)
        {
            Debug.Log("Player returns to beginning of level and loses 1 chip on shoulder");
            chipsOnShoulder += 1;
            if(chipsOnShoulder >= 3)
            {
                Debug.Log("Game Over");
            }
        }        
    }
}
