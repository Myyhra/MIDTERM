using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster_Count : MonoBehaviour
{
    // Start is called before the first frame update
    public UI_Manager ui;
    public int deadTimer = 0;
    void Awake()
    {
     ui = GameObject.Find("UI Manager").GetComponent<UI_Manager>();

    }
    void Start()
    {
        ui.RoosterScore++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(deadTimer);
        ui.RoosterScore--;
        Destroy(gameObject);
    }
}
