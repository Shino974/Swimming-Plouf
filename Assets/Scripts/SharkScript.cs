using UnityEngine;

public class SharkScript : MonoBehaviour
{
    public Shark3Generator Shark3Generator;

    void Update()
    {
        transform.Translate(Vector2.left * Shark3Generator.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            Shark3Generator.GenerateNextSharkWithGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
