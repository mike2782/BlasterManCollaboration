using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab = null;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        }
    }
}
