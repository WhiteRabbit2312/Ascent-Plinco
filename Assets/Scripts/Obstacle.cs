using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstaclesFirst;
    [SerializeField] private GameObject[] _obstaclesSecond;
    [SerializeField] private GameObject[] _obstaclesThird;

    private List<GameObject[]> obstacles = new List<GameObject[]>();
    private int[] _amount = { 4, 3, 2 };

    private void Awake()
    {
        obstacles.Add(_obstaclesFirst);
        obstacles.Add(_obstaclesSecond);
        obstacles.Add(_obstaclesThird);
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < _amount.Length; ++i)
        {
            GenerateObstacle(obstacles[i], _amount[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateObstacle(GameObject[] obstacle, int amount)
    {
        int rand = Random.Range(0, amount);

        Debug.Log("Rand " + rand);

        for(int i = 0; i < obstacle.Length; ++i)
        {
            if(i == rand)
            {
                obstacle[i].SetActive(false);
            }

            else
            {
                obstacle[i].SetActive(true);
            }
            

        }

    }
}
