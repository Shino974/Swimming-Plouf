using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector3 direction;
    private float move_y = 0;

    public float gravity = -9.8f;
    public float strenght = 5f;

    private void Update()
    {
        if (Input.GetKeyDown("up"))
            move_y += (float)0.05;
        if (Input.GetKeyDown("down"))
            move_y -= (float)0.05;
        transform.position += new Vector3(0, move_y, 0);
        move_y = 0;
        /*if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strenght;
        }*/

        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strenght;
            }
        }*/

        //direction.y += gravity * Time.deltaTime;
        //transform.position += direction * Time.deltaTime;
    }
}