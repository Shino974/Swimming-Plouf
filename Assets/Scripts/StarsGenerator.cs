using UnityEngine;

public class StarsGenerator : MonoBehaviour
{
    public GameObject shark;
    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    ScoreScript score;

    public float SpeedMultiplier;

    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateShark();
    }

    public void GenerateNextSharkWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateShark", randomWait);
    }
    public void generateShark()
    {
        GameObject SharkIns = Instantiate(shark, transform.position, transform.rotation);

        SharkIns.GetComponent<StarsScript>().StarsGenerator = this;
    }

    void Update()
    {
        if (CurrentSpeed < MaxSpeed)
        {
            CurrentSpeed += SpeedMultiplier;
        }
    }
}
