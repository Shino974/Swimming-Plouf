using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class StarsScript : MonoBehaviour
{
    public StarsGenerator StarsGenerator;
    public Collider2D colider;

    void Update()
    {
        transform.Translate(Vector2.left * StarsGenerator.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            StarsGenerator.GenerateNextSharkWithGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }

    }


}
