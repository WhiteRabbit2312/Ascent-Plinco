using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] private GameObject[] _coinsFirst;
    [SerializeField] private GameObject[] _coinsSecond;
    [SerializeField] private GameObject[] _coinsThird;
    // Start is called before the first frame update

    private List<GameObject[]> coins = new List<GameObject[]>();
    private readonly int _rowAmount = 3;

    private void Awake()
    {
        coins.Add(_coinsFirst);
        coins.Add(_coinsSecond);
        coins.Add(_coinsThird);
    }
    void Start()
    {
        for (int i = 0; i < _rowAmount; ++i)
        {
            GenerateCoins(coins[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateCoins(GameObject[] coins)
    {
        int rand = Random.Range(0, coins.Length);

        for (int i = 0; i < coins.Length; ++i)
        {
            if (i == rand)
            {
                coins[i].SetActive(true);
            }

            else
            {
                coins[i].SetActive(false);
            }


        }

    }
}
