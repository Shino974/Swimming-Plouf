using UnityEngine;

public class Player : MonoBehaviour
{
    private float move_y = 0;
    private float move_x = 0;

    private void Update()
    {
        if (Input.GetKey("up"))
            move_y += (float)0.03;
        if (Input.GetKey("down"))
            move_y -= (float)0.03;
        if (Input.GetKey("right"))
            move_x += (float)0.03;
        if (Input.GetKey("left"))
            move_x -= (float)0.03;
        transform.position += new Vector3(move_x, move_y, 0);
        move_y = 0;
        move_x = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
