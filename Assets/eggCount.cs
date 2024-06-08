using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggCount : MonoBehaviour
{
    public UI_Manager ui;
    [SerializeField] int hatchTimer = 10;
    [SerializeField] int height;
    public GameObject chick;
    Spawn ChickenLife;
    // Start is called before the first frame update
    void Awake()
    {
        ui = GameObject.Find("UI Manager").GetComponent<UI_Manager>();
//        ChickenLife = GameObject.Find("ChickenLife").GetComponent<Spawn>();

    }
    void Start()
    {
       
        ui.EggScore++;
        StartCoroutine(FirstHatching());
        
        
    }

    IEnumerator FirstHatching()
    {
        
        yield return new WaitForSeconds(hatchTimer);   
            Vector3 pos = gameObject.transform.position + Vector3.up * height;
            Instantiate(chick, pos, Quaternion.identity);
            ui.EggScore--;
            Destroy(gameObject);

        
    }
    

}
