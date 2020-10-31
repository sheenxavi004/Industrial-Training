using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControllerD : MonoBehaviour
{
    public bool switchCondition = false;
    public SwitchControllerA SA;
    public SwitchControllerB SB;
    public SwitchControllerC SC;
    public ExplosionSettings ES;

    void OnTriggerStay(Collider player) {
        if(player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !switchCondition) 
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -7);
            if(SA.switchCondition && !SB.switchCondition && SC.switchCondition)
                ;
            else
                ES.setExplosion();
            switchCondition = true;
        }
        else if (player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && switchCondition)
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 7);
            switchCondition = false;
        }  
    }
}
