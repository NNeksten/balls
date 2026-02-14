using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class FollowAtackTrigger : MonoBehaviour
{
    public GameObject targetCircle;
    Vector2 targetCor;
    quaternion rotation;
    void Update()
    {
        if(targetCircle){
            targetCor = targetCircle.transform.position;
            rotation = targetCircle.transform.rotation;

            transform.position = new Vector2(targetCor.x, targetCor.y);
            transform.rotation = rotation;
        }
    }
}
