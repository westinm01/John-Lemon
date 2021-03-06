using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameEnding gameEnding;
    bool m_IsPlayerInRange;
    public Health h;
    //public Canvas playUI;
    
    void Update ()
    {
        if(m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray (transform.position, direction);
            RaycastHit raycastHit;
            if(Physics.Raycast(ray, out raycastHit)) //returns bool which is true when hit something
            {
                if(raycastHit.collider.transform == player)
                {
                    //gameEnding.CaughtPlayer();//call healthDeplete here
                    h.inTrouble=true;
                    if(h.hp<=0){
                        gameEnding.CaughtPlayer();
                        //playUI.enabled=false;
                    }
                }
                
            }
        }
        
    }

    void OnTriggerEnter (Collider other)
    {
         if(other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }
    

    void OnTriggerExit (Collider other)
    {
        if(other.transform == player)
        {
            m_IsPlayerInRange = false;
            h.inTrouble=false;
        }
    }
}
