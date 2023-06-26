using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InTheShadow.System;

namespace InTheShadow.Event
{
    public class MainClickEvents : MonoBehaviour
    {
		[SerializeField] private GameObject _buttonGrounp1;
		[SerializeField] private GameObject _buttonGrounp2;

        public void OnClickStart()
        {
    		_buttonGrounp1.SetActive(false);
    		_buttonGrounp2.SetActive(true);
        }

        public void OnClickExit()
        {
			// GameManager.Instance.QuitGame();
        }

        public void OnClickNormalMode()
        {
			// GameManager.Instance.SetGameMode(GameMode.Normal);
			// GameManager.Instance.StartGame();
        }

        public void OnClickTestMode()
        {
			// GameManager.Instance.QuitGame(GameMode.Test);
			// GameManager.Instance.StartGame();
        }

        public void OnClickBack()
        {
    		_buttonGrounp1.SetActive(true);
    		_buttonGrounp2.SetActive(false);
        }
    }
}
