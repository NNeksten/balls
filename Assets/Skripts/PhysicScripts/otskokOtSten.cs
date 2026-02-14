using UnityEngine;

public class otskokOtSten : MonoBehaviour
{
    public GameObject circle;
    Rigidbody2D rbCircle;
    float velocity;
    float velocity1;
    
    int rngNum;
    float rngNumf;
    void Start()
    {
        rbCircle = circle.GetComponent<Rigidbody2D>();
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("wall"))
        {
            velocity = rbCircle.linearVelocityX;
            velocity1 = velocity;
            rbCircle.linearVelocity = new Vector2(0f, rbCircle.linearVelocity.y);
            rbCircle.linearVelocityX = velocity1 *= -1;

            if (rbCircle.linearVelocityX > 0)
            {
                rngNum = Random.Range(1,3);
                if(rngNum == 1){
                    rngNum = Random.Range(1, 6);
                    rbCircle.linearVelocityX += rngNum;
                }
                else
                {
                    rngNumf = Random.Range(1.3f, 2.3f);
                    rbCircle.linearVelocityX /= rngNumf;
                }
            }
            else
            {
                rngNum = Random.Range(1,3);
                if(rngNum == 1){
                    rngNum = Random.Range(-1, -6);
                    rbCircle.linearVelocityX += rngNum;
                }
                else
                {
                    rngNumf = Random.Range(1.3f, 2.3f);
                    rbCircle.linearVelocityX /= rngNumf;
                }
            }
            rngNum = 0;
        }
    }
}
