using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chick : MonoBehaviour
{
    public UI_Manager ui;
    [SerializeField] int height;
    [SerializeField] int evolveTimer = 10;
    public GameObject hen;
    public GameObject rooster;
    int flip;
    
    Spawn ChickenLife;

    void Awake()
    {
        ui = GameObject.Find("UI Manager").GetComponent<UI_Manager>();
        //ChickenLife = GameObject.Find("ChickenLife").GetComponent<Spawn>();
        
    }
    void Start()
    {
        ui.ChickScore++;
        ChooseRH();
    }

    void Update()
    {
       

    }
    void ChooseRH()
    {
        flip = Random.Range(0,2);
        if(ui.firsthen)
        {
            StartCoroutine(EvolveToHen());
            ui.firsthen = false;
        }

        else
        {

            if (flip == 0)
            {
             StartCoroutine(EvolveToHen());
             }
             if(flip >= 1)
             {
            StartCoroutine(EvolveToRooster());
             }
        }
       

        
    }
    IEnumerator EvolveToHen()
    {
        yield return new WaitForSeconds(evolveTimer);
        Vector3 posi = gameObject.transform.position  + Vector3.up * height;

        Instantiate(hen,posi, Quaternion.identity);
        ui.ChickScore--;
        Destroy(gameObject);

    }
    IEnumerator EvolveToRooster()
    {
        yield return new WaitForSeconds(evolveTimer);
        Vector3 posi = gameObject.transform.position  + Vector3.up * height;

        Instantiate(rooster,posi, Quaternion.identity);
        ui.ChickScore--;
        Destroy(gameObject);

        
    }
  
}
