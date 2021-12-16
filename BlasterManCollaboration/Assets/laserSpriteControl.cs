using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSpriteControl : MonoBehaviour
{
    [SerializeField]
    GameObject laser = null;

    public void laserOn(GameObject obj)
    {      
        Debug.Log("player should shoot");
        obj.SetActive(true);       
    }
        public void laserOff(GameObject obj)
    {
        obj.SetActive(false);
    }


    void Update()
    {
        bool shootInput = Input.GetKeyDown("space");

        if (shootInput == true && laser != null)
        {
            Debug.Log("space pressed!");
            laserOn(laser);
        }
        else 
        { 
            laserOff(laser);
        }
    }


}
