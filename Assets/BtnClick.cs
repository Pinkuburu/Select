using UnityEngine;
using System.Collections;


public class BtnClick : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject AboutUI;
    //public GameObject MoreBtn;
    public GameObject AboutBtn;
    public GameObject ReturnBtn;

    public void ClickAbout()
    {
        MainUI.SetActive(false);
        //MoreBtn.SetActive(false);
        AboutBtn.SetActive(false);
        ReturnBtn.SetActive(true);
        AboutUI.SetActive(true);
        

    }
    public void ClickReturn()
    {
        MainUI.SetActive(true);
        //MoreBtn.SetActive(true);
        AboutBtn.SetActive(true);
        ReturnBtn.SetActive(false);
        AboutUI.SetActive(false);
    }

    
}
