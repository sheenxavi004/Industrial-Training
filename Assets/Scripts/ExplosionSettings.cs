using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ExpBanner, Banner, A, B, C, D, Success;
    public Light light;
    public GameObject explode;
    public GameObject SA, SB, SC, SD;
    public SwitchControllerA AS;
    public SwitchControllerB BS;
    public SwitchControllerC CS;
    public SwitchControllerD DS;

    public void setExplosion()
    {
        explode.SetActive(true);
        Banner.SetActive(false);
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        ExpBanner.SetActive(true);
        light.color = Color.red;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Success.SetActive(false);
            explode.SetActive(false);
            Banner.SetActive(true);
            A.SetActive(true);
            B.SetActive(true);
            C.SetActive(true);
            D.SetActive(true);
            SA.SetActive(true);
            SB.SetActive(true);
            SC.SetActive(true);
            SD.SetActive(true);
            ExpBanner.SetActive(false);
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
