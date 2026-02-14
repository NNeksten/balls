using UnityEngine;

public class otskok : MonoBehaviour
{
    public GameObject circle;
    string circleName;
    Rigidbody2D rbCircle;
    public float impuls;
    void Start()
    {
        rbCircle = circle.GetComponent<Rigidbody2D>();
        circleName = circle.name;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("касание");
        if (other.CompareTag("Floor"))
        {
            Debug.Log("касание пола");
            rbCircle.linearVelocity = new Vector2(rbCircle.linearVelocityX, 0);
            impuls = Random.Range(10, 35);
            rbCircle.AddForce(Vector2.up * impuls, ForceMode2D.Impulse);

            if (rbCircle.linearVelocity.x > 0)
            {
                rbCircle.linearVelocityX += Random.Range(1, 3);
            }
            if (rbCircle.linearVelocity.x < 0)
            {
                rbCircle.linearVelocityX += Random.Range(-1, -3);
            }


        }
    }
}