using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blastBehaviour : MonoBehaviour
{
    public PlayerDamageController playerDamageController;
    public playerController player;
    public GameObject blastSkillPrefab1;
    public GameObject blastSkillPrefab2;
    public GameObject blastSkillPrefab3;
    public GameObject blastSkillPrefab4;
    public GameObject blastSkillPrefab5;
    public GameObject blastSkillPrefab6;
    public GameObject blastSkillPrefab7;
    public GameObject blastSkillPrefab8;

    public GameObject[] enemies;
    public GameObject[] moreEnemies;

    [SerializeField] 
    private float moveSpeed = 1.0f;
    private int i;

    // Update is called once per frame
    void Update()
    {
        if (player.blastActive == true)
        {
            Instantiate(blastSkillPrefab1, transform.position, transform.rotation);
            //blastSkillPrefab1 = transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab2, transform.position, transform.rotation);
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab3, transform.position, transform.rotation);
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab4, transform.position, transform.rotation);
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab5, transform.position, transform.rotation);
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab6, transform.position, transform.rotation);
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab7, transform.position, transform.rotation);
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);
            Instantiate(blastSkillPrefab8, transform.position, transform.rotation);
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);

            player.blastActive = false;
        }

        //UlttraBlast Mechanic
        if(player.ultaBlastActive == true)
        {
            if (enemies == null)
            {

                enemies = GameObject.FindGameObjectsWithTag("ShooterEnemy");


                for (i = 0; i < enemies.Length; i++)
                {
                    Debug.Log(enemies[i]);
                    Destroy(enemies[i]);
                }
            }

            if (moreEnemies == null)
            {

                moreEnemies = GameObject.FindGameObjectsWithTag("MeleeEnemy");

                for (i = 0; i < moreEnemies.Length; i++)
                {
                    Destroy(moreEnemies[i]);
                }
            }
        }
    }
}
