using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI EggCount;
    [SerializeField]TextMeshProUGUI ChickCount;
    [SerializeField]TextMeshProUGUI HenCount;
    [SerializeField]TextMeshProUGUI RoosterCount;
    public int EggScore;
    public int ChickScore;
    public int HenScore;
    public int RoosterScore;


    public bool firsthen;
    public bool firsthenDie;
    void Start()
    {
        firsthen = true;
        firsthenDie = true;
    }

    // Update is called once per frame
    void Update()
    {
        EggCount.text = "Egg Count: " + EggScore;
        ChickCount.text = "Chick Count: " + ChickScore;
        HenCount.text = "Hen Count: " + HenScore;
        RoosterCount.text = "Rooster Count: " + RoosterScore;

    }
}
