using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class HenchmanMeleeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] henchmanTypes = new GameObject[1] { null };

    [SerializeField] private float henchmanSpawnTime = 1.0f;
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
            countdown = henchmanSpawnTime;
        }
    }

    void generateHenchman()
    { 
        int typeIndex = rndGen.Next(2);

        GameObject henchman2 = Instantiate(henchmanTypes[typeIndex], new Vector2(2.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject henhcman3 = Instantiate(henchmanTypes[typeIndex], new Vector2(5.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject henchman5 = Instantiate(henchmanTypes[typeIndex], new Vector2(-2.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
        GameObject henhcman6 = Instantiate(henchmanTypes[typeIndex], new Vector2(-5.20f, (float)(rndGen.Next(10) - -10)), Quaternion.identity);
    }
}

