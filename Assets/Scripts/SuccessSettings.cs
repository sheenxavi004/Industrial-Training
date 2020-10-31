using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Banner, A, B, C, D, Success;
    public Light light;
    public GameObject explode, SA, SB, SC, SD;
    public SwitchControllerA AS;
    public SwitchControllerB BS;
    public SwitchControllerC CS;
    public SwitchControllerD DS;

    public void setSuccess()
    {
        if(!explode.activeSelf && AS.switchCondition && BS.switchCondition && CS.switchCondition && DS.switchCondition)
        {
            Success.SetActive(true);
            Banner.SetActive(false);
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(false);
            D.SetActive(false);
            SA.SetActive(false);
            SB.SetActive(false);
            SC.SetActive(false);
            SD.SetActive(false);
            light.color = Color.green;
            Update();
        }  
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Success.SetActive(false);
            Banner.SetActive(true);
            A.SetActive(true);
            B.SetActive(true);
            C.SetActive(true);
            D.SetActive(true);
            SA.SetActive(true);
            SB.SetActive(true);
            SC.SetActive(true);
            SD.SetActive(true);
            light.color = new Color32(180, 255, 239, 255);
            SA.transform.eulerAngles = new Vector3(0, 0, 7);
            SB.transform.eulerAngles = new Vector3(0, 0, 7);
            SC.transform.eulerAngles = new Vector3(0, 0, 7);
            SD.transform.eulerAngles = new Vector3(0, 0, 7);
            AS.switchCondition = false;
            BS.switchCondition = false;
            CS.switchCondition = false;
            DS.switchCondition = false;
        }
    }
}
