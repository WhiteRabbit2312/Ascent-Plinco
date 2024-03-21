using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private Image[] _backgrounds;
    [SerializeField] private Sprite[] _backgroundSprite;
    [SerializeField] private TextMeshProUGUI[] _backgroundButtonText;
    private readonly int[] _backgroundPrice = { 10000, 20000, 30000, 40000, 50000 };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyBackgroundButton(int idx)
    {
        if(_backgroundPrice[idx] < CashManager.Cash)
        {
            foreach (var item in _backgrounds)
            {
                item.sprite = _backgroundSprite[idx];

            }
            _backgroundButtonText[idx].text = "Choose";
            CashManager.ChangeSum(-_backgroundPrice[idx]);
        }
       
    }
}
