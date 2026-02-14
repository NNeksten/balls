using UnityEngine;

public class otskokOtCircle : MonoBehaviour
{
    public GameObject circle;
    Rigidbody2D rbCircle;
    Rigidbody2D otherRbCircle;


    float circleVelocityX;
    float circleVelocityY;
    float otherCircleVelocityX;
    float otherCircleVelocityY;

    float velocityTempX;
    float velocityTempY;
    float otherVelocityTempX;
    float otherVelocityTempY;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("circle"))
        {

            if(circle.GetInstanceID() < collision.gameObject.GetInstanceID()){return;}

            rbCircle = circle.GetComponent<Rigidbody2D>();
            otherRbCircle = collision.GetComponent<Rigidbody2D>();

            velocityTempX = rbCircle.linearVelocityX;
            velocityTempY = rbCircle.linearVelocityY;

            otherVelocityTempX = otherRbCircle.linearVelocityX;
            otherVelocityTempY = otherRbCircle.linearVelocityY;

            rbCircle.linearVelocity = new Vector2(otherVelocityTempX, otherVelocityTempY);
            otherRbCircle.linearVelocity = new Vector2(velocityTempX, velocityTempY);

        }
    }
}
