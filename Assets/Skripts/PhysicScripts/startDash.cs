using UnityEngine;

public class startDash : MonoBehaviour
{
    public GameObject circle;
    public Rigidbody2D rbCircle;
    float rngNum;
    int kuda;
    void Start()
    {
        kuda = Random.Range(1, 3);
        rbCircle = circle.GetComponent<Rigidbody2D>();
        if(kuda == 1){
            rngNum = Random.Range(4f, 8f);
            rbCircle.linearVelocityX = rngNum;
        }
        else
        {
            rngNum = Random.Range(-4f, -8f);
            rbCircle.linearVelocityX = rngNum;
        }
        
    }

}
