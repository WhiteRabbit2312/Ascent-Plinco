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

    [SerializeField] private Button _bidButton;
    [SerializeField] private Button _takeButton;
    [SerializeField] private GameObject _coefficient;
    [SerializeField] private GameObject _sticks;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveController();
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
            _bidButton.gameObject.SetActive(true);
            _takeButton.gameObject.SetActive(true);
        }
    }

    public void Take()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        _coefficient.SetActive(true);
        _sticks.SetActive(false);
        gameObject.transform.localScale = new Vector2(1.5f, 1.5f);
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        foreach(var item in coins)
        {
            item.gameObject.SetActive(false);
        }
    }
}
