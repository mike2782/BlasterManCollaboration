using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   

    [SerializeField]
    private float speed = 5.0f;

    [SerializeField]
    private float damage = 4.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = speed * Time.deltaTime;
        transform.Translate(new Vector3(0.0f, -moveX, 0.0f));
    }
}

