using UnityEngine;

public class MoveToObj : MonoBehaviour
{
    public GameObject target;
    Vector2 targetCor;
    void Update()
    {   if(target){
            targetCor = target.transform.position;
            transform.position = targetCor;
        }
        else
        Destroy(gameObject);
    }
}
