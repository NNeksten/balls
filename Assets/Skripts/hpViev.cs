using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hpViev : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public TextMeshProUGUI hpBar1;
    public TextMeshProUGUI hpBar2;

    int hp1;
    Statistic stat1;
    Statistic stat2;
    int hp2;

    void Start()
    {
        stat1 = ball1.GetComponent<Statistic>();
        stat2 = ball2.GetComponent<Statistic>();
    }
    void Update()
    {
        if(ball1 && ball2 && hpBar1 && hpBar2)
        {
            hp1 = stat1.hp;
            hp2 = stat2.hp;

            hpBar1.text = "" +hp1;
            hpBar2.text = "" +hp2;  
        }
        
    }
}
