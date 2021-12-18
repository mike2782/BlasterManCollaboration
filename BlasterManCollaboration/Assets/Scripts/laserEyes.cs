using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserEyes : MonoBehaviour
{
    //Set the speed of the line drawing movement
    [SerializeField]
    private int speed;

    //A timer to delete the line
    [SerializeField]
    private float deleteTimer = 0.1f;

    //Setting an array of lines in the line renderer
    private LineRenderer[] lines;

    //This was used for testing
    float length = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //We take the children of the parent object (prefab object) and put the lines into the array
        lines = gameObject.GetComponentsInChildren<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //The length of the line increased with the frames
        length += Time.deltaTime * speed;
        //Debug.Log("Length: " + length);

        //Loop over each line, sets the position
        foreach (LineRenderer line in lines)
        {
            line.SetPosition(1, new Vector3(0.0f, length, 0.0f));
        }

        //Timer counts down
        deleteTimer -= Time.deltaTime;

        //Statement to remove the lines from the scene after the timer reaches 0. Timer then resets
        if (deleteTimer <= 0)
        {
            //Debug.Log("delete lines");
            deleteTimer = 0.1f;
            Destroy(this.gameObject);

        }

        if (Input.GetKeyDown("space"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            Debug.DrawLine(transform.position, hit.point);
            if (hit && hit.collider.name != "Player")
            {
                Debug.Log("Hit:" + hit.collider.name);
            }
            
        }
    }
}
