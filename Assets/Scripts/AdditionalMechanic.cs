using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditionalMechanic : MonoBehaviour
{
    [SerializeField] private GameObject dodge;
    [SerializeField] private GameObject stop;
    [SerializeField] private GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DodgeBuy()
    {
        if (CashManager._cash >= 80000)
        {
            dodge.SetActive(true);
            CashManager.ChangeSum(-80000);
        }
    }

    public void StopBuy()
    {
        if (CashManager._cash >= 100000)
        {
            stop.SetActive(true);
            CashManager.ChangeSum(-100000);
        }
    }

    public void ShieldBuy()
    {
        if (CashManager._cash >= 200000)
        {
            shield.SetActive(true);
            CashManager.ChangeSum(-200000);
        }
    }

}
