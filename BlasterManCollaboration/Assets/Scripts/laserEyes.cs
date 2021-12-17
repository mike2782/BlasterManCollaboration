using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserEyes : MonoBehaviour
{
    [SerializeField]
    private int speed = 100;

    [SerializeField]
    private float deleteTimer = 0.1f;


    private LineRenderer[] lines;
    float length = 0.0f;
    // Start is called before the first frame update

    void Start()
    {
        lines = gameObject.GetComponentsInChildren<LineRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        length += Time.deltaTime * speed;
        Debug.Log("Length: " + length);
        foreach(LineRenderer line in lines)
        {
            line.SetPosition(1, new Vector3(0.0f, length, 0.0f));
        }

        Debug.Log(deleteTimer);
        deleteTimer -= Time.deltaTime;

        if (deleteTimer <= 0) {
            Debug.Log("delete lines");
            deleteTimer = 0.1f;
            Destroy(this.gameObject);
            
        }
    }
}
