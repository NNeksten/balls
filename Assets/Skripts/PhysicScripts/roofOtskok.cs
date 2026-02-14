using UnityEngine;

public class roofOtskok : MonoBehaviour
{
    public GameObject circle;
    Rigidbody2D rbCircle;
    public float impuls;
    void Start()
    {
        rbCircle = circle.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("roof"))
        {
            rbCircle.linearVelocity = new Vector2(rbCircle.linearVelocityX, 0);
            impuls = Random.Range(9, 18);
            rbCircle.AddForce(Vector2.down * impuls, ForceMode2D.Impulse);
            
        }
    }
}