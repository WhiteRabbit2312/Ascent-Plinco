using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject storePanel;
    [SerializeField] private GameObject backgroundPanel;
    [SerializeField] private GameObject musicPanel;
    [SerializeField] private Button tapToPlayButton;
    [SerializeField] private GameObject freeSpinPanel;

    [SerializeField] private Animator _topHeaderAnim;
    [SerializeField] private Animator _bottonHeaderAnim;
    private bool _closeOpenStore;
    private bool _closeOpenTutorial;
    // Start is called before the first frame update
    void Start()
    {
        _closeOpenStore = true;
        _closeOpenTutorial = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayButton()
    {
        menuPanel.SetActive(false);
       
    }

    public void TapToPlayButton()
    {
        _topHeaderAnim.SetBool("CloseMenuTop", true);
        _bottonHeaderAnim.SetBool("CloseMenuBottom", true);
        tapToPlayButton.gameObject.SetActive(false);
    }

    public void ReturnToMenuButton()
    {
        _topHeaderAnim.SetBool("CloseMenuTop", false);
        _bottonHeaderAnim.SetBool("CloseMenuBottom", false);
        tapToPlayButton.gameObject.SetActive(true);
    }

    public void SpinWheel()
    {
        freeSpinPanel.SetActive(true);
    }

    public void Menu()
    {
        menuPanel.SetActive(true);
    }

    public void Tutorial()
    {
        tutorialPanel.SetActive(_closeOpenTutorial);
        _closeOpenTutorial = !_closeOpenTutorial;
    }

    public void Store()
    {
        storePanel.SetActive(_closeOpenStore);
        _closeOpenStore = !_closeOpenStore;
    }

    public void Background()
    {
        backgroundPanel.SetActive(true);
    }

    public void Music()
    {
        musicPanel.SetActive(true);
    }

    public void Back(GameObject closePanel)
    {
        closePanel.SetActive(false);
    }
}
