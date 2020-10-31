using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControllerA : MonoBehaviour
{
    public bool switchCondition = false;
    public SwitchControllerB SB;
    public SwitchControllerC SC;
    public SwitchControllerD SD;
    public ExplosionSettings ES;

    void OnTriggerStay(Collider player) {
        if(player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !switchCondition) 
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -7);
            if(!SB.switchCondition && SC.switchCondition && !SD.switchCondition)
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
