using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControllerB : MonoBehaviour
{
    public bool switchCondition = false;
    public SwitchControllerA SA;
    public SwitchControllerC SC;
    public SwitchControllerD SD;
    public ExplosionSettings ES;
    public SuccessSettings SS;

    void OnTriggerStay(Collider player) {
        if(player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !switchCondition) 
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -7);
            if(SA.switchCondition && SC.switchCondition && SD.switchCondition)
                ;
            else
                ES.setExplosion();
            switchCondition = true;
            SS.setSuccess();
        }
        else if (player.tag == "Player" && Input.GetKeyDown(KeyCode.E) && switchCondition)
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 7);
            switchCondition = false;
        } 
    }
}
