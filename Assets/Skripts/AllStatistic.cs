using TMPro;
using UnityEngine;

public class AllStatistic : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    Statistic statistic1;
    Statistic statistic2;
    int hp1;
    int hp2;
    public TextMeshProUGUI TMP;
    
    void Update()
    {
        if(ball1 && ball2){
            statistic1 = ball1.GetComponent<Statistic>();
            statistic2 = ball2.GetComponent<Statistic>();
        
            hp1 = statistic1.hp;
            hp2 = statistic2.hp;
        }
        if(hp1 <= 0)
        {
            TMP.text = "победил шар 2";
        }
        if(hp2 <= 0)
        {
            TMP.text = "победил шар 1";
        }
    }
}
