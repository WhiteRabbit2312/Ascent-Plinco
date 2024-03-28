using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundInGame : MonoBehaviour
{
    [SerializeField] private Sprite onSoundSprite;
    [SerializeField] private Sprite offSoundSprite;
    [SerializeField] private AudioSource gameMusic;
    [SerializeField] private Image soundButton;
    private bool _switchSound;
    // Start is called before the first frame update
    void Start()
    {
        gameMusic.volume = 0f;
        //_switchSound = !_switchSound;
        soundButton.sprite = offSoundSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchMusic()
    {
        if (_switchSound)
        {
            gameMusic.volume = 0f;
            _switchSound = !_switchSound;
            soundButton.sprite = offSoundSprite;
        }

        else
        {
            gameMusic.volume = 1f;
            _switchSound = !_switchSound;
            soundButton.sprite = onSoundSprite;
        }
    }
}
