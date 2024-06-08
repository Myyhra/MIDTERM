using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public UI_Manager ui;
    public bool startGame;
    public GameObject chickenLife;
    public GameObject chick;
    public GameObject hen;
    public GameObject rooster;
    [SerializeField] GameObject egg;
    [SerializeField] int hatchTimer = 10;
    [SerializeField] int evolveHenTimer = 10;
    [SerializeField] int deadTimer = 40;
    [SerializeField] bool isHatching;

    [SerializeField] int height;
     bool disableScript;
     Spawn spawn;
    Vector3 eggLastPos;
    void Awake()
    {
        Application.targetFrameRate = 60;
        ui = GameObject.Find("UI Manager").GetComponent<UI_Manager>();

    }
    void Start()
    {
        
        egg = GameObject.FindGameObjectWithTag("Egg");
        spawn = GetComponent<Spawn>();
        eggLastPos = egg.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FirstHatching());
        }
        if(disableScript)
        {
            spawn.enabled = false;
        }

    }
    

    IEnumerator FirstHatching()
    {
        yield return new WaitForSeconds(hatchTimer);
        Vector3 pos = eggLastPos + Vector3.up * height;
        Instantiate(chick, pos, Quaternion.identity);  
        startGame = true;
        
           // StartCoroutine(EvolveToHen());
    }

    /* IEnumerator EvolveToHen()
    {
        yield return new WaitForSeconds(evolveHenTimer);
        chick = GameObject.FindGameObjectWithTag("Chick");
        Vector3 posi = chick.transform.position  + Vector3.up * height;

        Instantiate(hen,posi, Quaternion.identity);
        StartCoroutine(Dead());
        ui.ChickScore--;
        Destroy(chick);

    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(deadTimer);
        GameObject hen = GameObject.FindGameObjectWithTag("Hen");
        ui.HenScore--;
        disableScript = true;
        Destroy(hen);
    } */
    

    
}
