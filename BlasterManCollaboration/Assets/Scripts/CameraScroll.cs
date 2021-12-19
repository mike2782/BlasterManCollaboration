using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    [SerializeField] private float cameraSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0.0f, cameraSpeed, 0.0f);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
}
