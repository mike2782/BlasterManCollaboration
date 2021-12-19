using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{

    [SerializeField]
    GameObject BackgroundPrefab;


    [SerializeField]
    public float spawnTimer = 5.0f;
    GameObject currentBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0.1)
        {
            spawnTimer = 10.0f;
            currentBackground = Instantiate(BackgroundPrefab, new Vector3(2, 13, 0), transform.rotation);
            //currentBackground.transform.parent = transform;
        }
    }
}
