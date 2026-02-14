using UnityEngine;

public class Statistic : MonoBehaviour
{
    public int hp = 100;

    void Update()
    {
        if(hp < 1)
        Destroy(gameObject);
    }
}
