using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] bulletTypes = null;

    [SerializeField] private float bulletSpawnTime = 0.0f;
    private float countdown = 0.0f;

    System.Random rndGen;

    // Start is called before the first frame update
    void Start()
    {
        rndGen = new System.Random();
    }


    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= -3.0f)
        {
            generateHenchman();
            countdown = bulletSpawnTime;
        }
    }

    void generateHenchman()
    {
        int typeIndex = rndGen.Next(2);

        GameObject bullet = Instantiate(bulletTypes[typeIndex], new Vector2(0.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject bullet2 = Instantiate(bulletTypes[typeIndex], new Vector2(8.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject bullet3 = Instantiate(bulletTypes[typeIndex], new Vector2(-8.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
    }
}
