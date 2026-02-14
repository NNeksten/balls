using System.Collections;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Animations;

public class AtackTrigger : MonoBehaviour
{
    public GameObject circle;
    Rigidbody2D rb;
    GameObject parentCircle;
    Statistic stats;
    Rigidbody2D otherRb;
    float tempVelocityX;
    float tempVelocityY;
    int rot;
    SpriteRenderer Color; 
    rotation rotation;
    rotation circleRotation;

    bool cd = false;

    void Update()
    {
        if(!circle)
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("circle") && cd == false)
        {

            if(collision.gameObject == circle && !circle)
            {
                return;
            }
            else if(collision.gameObject != circle && circle)
            {
                rotation = collision.GetComponent<rotation>();
                circleRotation = circle.GetComponent<rotation>();
                cd = true;
                StartCoroutine(cdTimer());
                rb = collision.GetComponent<Rigidbody2D>();
                rb.linearVelocityX *= -1;
                rb.linearVelocityY *= -1;

                stats = collision.GetComponent<Statistic>();
                stats.hp -= 10;
                
                otherRb = collision.GetComponent<Rigidbody2D>();

                rot = circleRotation.rot;
                if(rot == 1 )
                    circleRotation.rot = 2;
                else{
                    circleRotation.rot = 1;
                }
                Color = collision.GetComponent<SpriteRenderer>();

                StartCoroutine(Timer());

            }
        }
    }

    
    UnityEngine.Color tempColor;
    IEnumerator Timer()
    {
        tempVelocityX = otherRb.linearVelocityX;
        tempVelocityY = otherRb.linearVelocityY;
        rb.constraints  = RigidbodyConstraints2D.FreezeAll;
        rotation.freeze = true;

        tempColor = Color.color;
        Color.color = new Color(255,0,0);

        yield return new WaitForSeconds(0.4f);
        if(rb && otherRb && rotation && Color){
            rb.constraints = RigidbodyConstraints2D.None;
            otherRb.linearVelocity = new Vector2(tempVelocityX, tempVelocityY);
            Color.color = tempColor;
            rotation.freeze = false;
        }
    }

    IEnumerator cdTimer()
    {
        yield return new WaitForSeconds(1f);
        cd = false;
    }

}