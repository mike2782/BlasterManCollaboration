using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBoost : MonoBehaviour
{
    public PlayerDamageController playerDamageController;
    public playerController player;
    private float randomDrop;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }







    }
    // Update is called once per frame
    void Update()
    {

    }

}
