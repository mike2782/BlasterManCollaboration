using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float shootSpeed;

    [SerializeField]
    GameObject blastSkillObjects;

    [SerializeField]
    GameObject laserEyes;

    [SerializeField]
    float egoMeter = 100;

    [SerializeField]
    float energyMeter = 100;

    [SerializeField]
    float chipsOnShoulder;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            egoMeter -= 10;           
            Debug.Log(egoMeter);
        }
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chipsOnShoulder <= 0)
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
            //laserEyes.renderer.enabled = false;
        }

        if(egoMeter <= 0)
        {
            Debug.Log("Player returns to beginning of level and loses 1 chip on shoulder");
            chipsOnShoulder -= 0;
        }

        if(chipsOnShoulder <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}