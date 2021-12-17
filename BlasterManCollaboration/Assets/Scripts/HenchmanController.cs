using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit Player");
            }
    }


    // Update is called once per frame
    void Update()
{
    transform.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.World);

}
       
    
}

