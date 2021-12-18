using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooter : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bulletTypes = null;

    [SerializeField] private float bulletSpawnTime = 1.0f;
    private float countdown = 0.0f;

    [SerializeField]
   private float speed = 2.0f;

    [SerializeField]
    private float damage = 4.0f;

    System.Random rndGen;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BottomBarrier")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    void update()
    {
        float MoveY = speed * Time.deltaTime;
        transform.Translate(new Vector3(0.0f, MoveY, 0.0f));
        countdown -= Time.deltaTime;

        if (countdown <= -3.0f)
        {
            generateBullet();
            countdown = bulletSpawnTime;
        }
    }

    void generateBullet()

    {
        int typeIndex = rndGen.Next(2);

        GameObject bullet1 = Instantiate(bulletTypes[typeIndex], new Vector2(0.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject bullet2 = Instantiate(bulletTypes[typeIndex], new Vector2(8.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject bullet3 = Instantiate(bulletTypes[typeIndex], new Vector2(-8.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);

    }

}
