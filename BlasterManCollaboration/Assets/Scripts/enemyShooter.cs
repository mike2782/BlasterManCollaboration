using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooter : MonoBehaviour
{

    [SerializeField]
    private GameObject rocketPrefab = null;

    [SerializeField]
    private float fireDelayTime = 0.0f;

    private float fireCounter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            fireCounter -= Time.deltaTime;
        }
    }


