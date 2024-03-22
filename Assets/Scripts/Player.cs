using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private int _speed;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _finishPosition;

    [SerializeField] private Button _bidButton;
    [SerializeField] private Button _takeButton;
    [SerializeField] private GameObject _gamepad;
    [SerializeField] private Button _jump;
    [SerializeField] private GameObject _coefficient;
    [SerializeField] private GameObject _sticks;
    [SerializeField] private GameObject _shield;

    private bool _finishedGame;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _finishedGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_finishedGame)
        {
            MoveController();
        }
        
    }



    private void MoveController()
    {
        Vector2 moveDirection = moveAction.action.ReadValue<Vector2>();
        transform.Translate(moveDirection * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            CashManager.ChangeSum(1000);
            Destroy(collision.gameObject);
        }

        if(collision.tag == "Obstacle")
        {
            gameObject.transform.position = _startPosition.position;
        }

        if (collision.tag == "Finish")
        {
            _bidButton.GetComponent<Animator>().SetBool("Bet", true);
            _takeButton.GetComponent<Animator>().SetBool("Take", true);
            gameObject.transform.position = _finishPosition.position;
            _finishedGame = true;
        }
    }

    public void Shield()
    {
        StartCoroutine("ShieldCoolDown");
    }

    private IEnumerator ShieldCoolDown()
    {
        _shield.SetActive(true);
        yield return new WaitForSeconds(5f);
        _shield.SetActive(false);
    }

    public void Take()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        _coefficient.SetActive(true);
        _sticks.SetActive(false);
        //gameObject.transform.localScale = new Vector2(1.5f, 1.5f);
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        _bidButton.GetComponent<Animator>().SetBool("Bet", false);
        _takeButton.GetComponent<Animator>().SetBool("Take", false);

        foreach (var item in coins)
        {
            item.gameObject.SetActive(false);
        }

        _gamepad.GetComponent<Animator>().SetBool("Gamepad", true);
        _jump.GetComponent<Animator>().SetBool("Jump", true);
    }
}
