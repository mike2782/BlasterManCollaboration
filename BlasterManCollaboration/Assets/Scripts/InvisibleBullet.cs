using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBullet : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private float destroyTimer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.World);
        destroyTimer -= Time.deltaTime;

        if(destroyTimer <= 0.1)
        {
            Destroy(this.gameObject);
        }
    }
}
