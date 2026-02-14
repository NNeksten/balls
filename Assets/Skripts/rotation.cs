using System.Collections;
using UnityEngine;

public class rotation : MonoBehaviour
{
    GameObject circle;
    void Start()
    {
        StartCoroutine (Rotation());
    }
    public int rot = 1;
    public bool freeze = false;
    IEnumerator Rotation()
    {
        while (true){
            yield return new WaitForSeconds(0.01f);
            if(freeze == false){
                if(rot == 1)
                    transform.Rotate(0,0, Random.Range(1, 4));
                else
                    transform.Rotate(0,0, Random.Range(-1, -4));
            }
        }
    }
}

