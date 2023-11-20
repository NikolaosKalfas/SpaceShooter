using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOVer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isGameOVer == true)
        {
            SceneManager.LoadScene(1); // Current Game Scene
        }
    }

    public void GameOVer()
    {
        _isGameOVer = true;
    }
}
