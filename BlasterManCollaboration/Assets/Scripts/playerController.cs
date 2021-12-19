using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public PlayerDamageController playerDamageController;
    public blastBehaviour blastScript;

    bool justDodged = false;
    public bool shieldOn;
    public bool blastActive = false;
    float shieldTimer = 2.0f;

    [SerializeField]
    float speed;

    [SerializeField]
    float shootTimer = 0.5f;

    [SerializeField]
    float dodgeTimer = 2.0f;

    [SerializeField]
    float dodgeSpeed;

    [SerializeField]
    GameObject blastSkillPrefab;

    [SerializeField]
    GameObject laserEyes;

    [SerializeField]
    GameObject invisibleBullet;

    [SerializeField]
    GameObject shieldPrefab;

    //Variables for the instantiations into the scene
    GameObject currentLaserEyes;
    GameObject currentInvisibleBullet;
    GameObject currentShield;
    GameObject currentBlastBall;

    public float energyMeter = 100;   
 
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

                //This was a "hack" to make the laser eye skill work quickly. A Raycast is the preferred method
                //This just instantiates and invisible bullet which performs the collisions
                currentInvisibleBullet = Instantiate(invisibleBullet, transform.position, transform.rotation);
                currentInvisibleBullet.transform.parent = transform;
                //Resets shoot timer each time fired
                shootTimer = 0.5f;
            }
        }              
        
        //Shield mechanic. First checks if e is pressed and if the shield is already on, then checks energy is not less than 20
        if (Input.GetKeyDown("e") && shieldOn == false && energyMeter > 19)
        {
            //Takes 20 energy away then turn on the bool for showing the shield is in use
            energyMeter -= 20;
            Debug.Log(energyMeter);
            shieldOn = true;
            //then instantiates the shield and sets the position to the player object (parent)
            currentShield = Instantiate(shieldPrefab, transform.position, transform.rotation);
            currentShield.transform.parent = transform;
        }

        //When shield is on, we reduce the timer and then turn off shield bool and detroy the prefab object. Resets timer
        if (shieldOn == true)
        {
            shieldTimer -= Time.deltaTime;
            if(shieldTimer <= 0.1)
            {
                shieldOn = false;
                Destroy(currentShield);
                shieldTimer = 2.0f;
            }
        }
        
        //Blast Mechanic
        if(Input.GetKeyDown("q") == true && energyMeter > 50)
        {
            blastActive = true;
        }

        //Control variables
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Calculate movement vector
        // Vector2 moveVector;

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0.0f);
        movement.Normalize();
        movement = movement * speed * Time.deltaTime;

        

        /* Vector2 horizontal = Vector2.right * horizontalInput;
        Vector2 vertical = Vector2.up * verticalInput;
         moveVector = (horizontal + vertical) * speed * Time.deltaTime;
        moveVector.Normalize(); */

        //Apply movement
        //transform.Translate(new Vector3(moveVector.x, moveVector.y, 0.0f));
        transform.Translate(movement);

        //Dodge mechanic
        if (Input.GetKeyDown("[8]") && dodgeTimer >= 1.9f)
        {
            justDodged = true;
            transform.Translate(new Vector3(0.0f,dodgeSpeed, 0.0f));
        }
        
        if (Input.GetKeyDown("[6]") && dodgeTimer >= 1.9f)
        {
            justDodged = true;
            transform.Translate(new Vector3(dodgeSpeed + 2, 0.0f, 0.0f));
        }
        if (Input.GetKeyDown("[4]") && dodgeTimer >= 1.9f)
        {
            justDodged = true;
            transform.Translate(new Vector3(-dodgeSpeed - 2, 0.0f, 0.0f));
        }
        if (Input.GetKeyDown("[2]") && dodgeTimer >= 1.9f)
        {
            justDodged = true;
            transform.Translate(new Vector3(0.0f, -dodgeSpeed, 0.0f));
        }

        if (justDodged == true)
        {
            dodgeTimer -= Time.deltaTime;                     
        } 

        if (dodgeTimer <= 0.1)
        {
            justDodged = false;
            dodgeTimer = 2.0f;
        }
    }
}
