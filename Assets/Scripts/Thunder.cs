using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    [SerializeField] private Transform[] _thunder;
    private int[] _yPos = { 77 , -61 , -218 };
    bool _switch;
    bool _switch1;
    bool _switch2;
    bool bet;
    // Start is called before the first frame update
    void Start()
    {
        bet = false;
        _switch = true;
        _switch1 = true;
        _switch2 = true;
        /*
        int i = 0;
        foreach(var item in _thunder)
        {
            ThunderLocation(item, _yPos[i]);
            ++i;
        }*/
    }

    int timer = 0;
    int timer1 = 30;
    int timer2 = 50;
    // Update is called once per frame
    void Update()
    {
        if (!bet)
        {
            timer++;
            if (timer == 60 * 3)
            {

                _thunder[0].gameObject.SetActive(_switch);

                timer = 0;
                _switch = !_switch;
            }

            timer1++;
            if (timer1 == 60 * 3)
            {

                _thunder[1].gameObject.SetActive(_switch1);

                timer1 = 0;
                _switch1 = !_switch1;
            }

            timer2++;
            if (timer2 == 60 * 3)
            {

                _thunder[2].gameObject.SetActive(_switch2);

                timer2 = 0;
                _switch2 = !_switch2;
            }
        }

    }

    public void HideThunder()
    {
        bet = true;
        foreach (var item in _thunder)
        {
            item.gameObject.SetActive(false);
        }
    }
}
