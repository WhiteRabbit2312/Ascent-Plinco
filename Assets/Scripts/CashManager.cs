using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashText;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private GameObject buyPanel;
    public static int _cash;
    private int _allCash;

    // Start is called before the first frame update
    private void Awake()
    {
        _cash = 1000;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = _cash.ToString();
    }

    public static void ChangeSum(int sum)
    {
        _cash += sum;
    }

    public void TakeMoney()
    {
        buyPanel.SetActive(true);
        _allCash += _cash;
        cashText.text = _allCash.ToString();
        _cash = 0;
        coinText.text = _cash.ToString();
    }
}
