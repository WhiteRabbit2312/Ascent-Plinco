using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    [SerializeField] private Transform[] _thunder;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in _thunder)
        {
            ThunderLocation(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ThunderLocation(Transform thunder)
    {
        float randomX = Random.Range(0, 2);

        Vector3 currentPosition = transform.position;

        currentPosition.x = randomX;
        thunder.transform.position = currentPosition;
    }
}
