using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public bool inTrouble;
    public int hp;
    public float hpPeriod;
    float elapsedTime;
    [SerializeField]private Text hp_text;
    // Start is called before the first frame update
    void Start()
    {
        hp=100;
        elapsedTime=0;
        inTrouble=false;
        hp_text.text=hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrouble){
            elapsedTime+=Time.deltaTime;
            
            if(elapsedTime>=hpPeriod && hp>0){
                hp--;
                elapsedTime=0;
            }
            
            hp_text.text=hp.ToString();
        }
    }
    
}
