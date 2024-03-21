using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cashText;
    private static int _cash;
    private int _cashBid;
    public static int Cash
    {
        get { return _cash; }
        set
        {
            _cash = value;
        }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        _cash = 1000000;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cashText.text = _cash.ToString();
    }

    public static void ChangeSum(int sum)
    {
        _cash += sum;
        
    }
}
