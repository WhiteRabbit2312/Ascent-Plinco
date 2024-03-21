using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _musicButtonText;
    private readonly int[] _musicPrice = { 10000, 20000, 30000, 40000, 50000 };
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyMusicButton(int idx)
    {
        if(_musicPrice[idx] < CashManager.Cash)
        {
            _musicButtonText[idx].text = "Choose";
            CashManager.ChangeSum(-_musicPrice[idx]);
        }

        
    }
}
