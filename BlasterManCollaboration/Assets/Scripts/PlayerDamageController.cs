using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour
{
    [SerializeField]
    public playerController player; 

    public int chipsOnShoulder = 0;
    public float egoMeter = 100;

    [SerializeField]
    GameObject blasterMan;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet" && player.shieldOn == false)
        {
            egoMeter -= 10;
            Debug.Log("10 damage from bullet. Ego remaining :" + egoMeter);
        }

        if (collision.gameObject.tag == "EnemyDamage" && player.shieldOn == false)
        {
            egoMeter -= 5;
            Debug.Log("10 damage from enemy collision. Ego remaining :" + egoMeter);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This reduces the lives (chips) by 1 if the ego meter (health) reached 0 or less and also if chips reach 3, game over
        if (egoMeter <= 0)
        {
            chipsOnShoulder += 1;
            Debug.Log("Player adds 1 chip on shoulder. Chips on shoulder: " + chipsOnShoulder);

            
            if (chipsOnShoulder >= 3)
            {
                Destroy(blasterMan);
                Debug.Log("Game Over. Player can restart the level with vanilla BlasterMan");
            }
            //Reset ego meter if not a game over
            egoMeter += 100;
        }

        if(player.shieldOn == true)
        {
            //Debug.Log("Shield on from damage control!");
        }

    }
}
