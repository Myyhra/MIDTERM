using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Hen : MonoBehaviour
{
    // Spawn chick;
    [SerializeField] int layEggTimer = 30;
    [SerializeField] int deadTimer = 40;
    bool Lay;
    public GameObject eggGameObject;
    public UI_Manager ui;

    // Start is called before the first frame update
    void Awake()
    {
        ui = GameObject.Find("UI Manager").GetComponent<UI_Manager>();

    }
    void Start()
    {
        ui.HenScore++;
        // chick = GameObject.Find()
        StartCoroutine(LayEgg());
        if(ui.firsthenDie == true)
        {
        StartCoroutine(Dead());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Lay == true)
        {
        LayEggs();

        }
    }

    void EvolveHen()
    {

    }
    IEnumerator LayEgg()
    {
        yield return new WaitForSeconds(layEggTimer);
        Lay = true;
    }
    void LayEggs()
    {
        int eggs = UnityEngine.Random.Range(2, 10);
        for(int i = 0; i < eggs; i++)
        {
            Instantiate(eggGameObject,gameObject.transform.position + Vector3.up * 7,gameObject.transform.rotation);
        }
        Lay = false;
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(deadTimer);
        ui.HenScore--;
        ui.firsthenDie = false;
        Destroy(gameObject);
    }
}
