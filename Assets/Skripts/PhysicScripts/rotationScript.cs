using System.Collections;
using System.Threading;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public int rot = 1;
    public GameObject circle;
    void Start()
    {
        StartCoroutine(Timer());
    }
    void rotation()
    {
        if(rot == 1)
        circle.transform.Rotate(0,0,Random.Range(1, 3));
        else
        circle.transform.Rotate(0,0,Random.Range(-1, -3));
    }
    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            rotation();
        }
        
    }
}
