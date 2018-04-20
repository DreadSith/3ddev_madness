using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PlayAgain : MonoBehaviour {

    public GameObject GameOverText;
    public GameObject ScreenFader;
    public GameObject Play;
    public GameObject Exit;

    // Use this for initialization
    void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Click);
    }
	
	// Update is called once per frame
	void Click () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        GameOverText.SetActive(false);
        ScreenFader.SetActive(false);
        Play.SetActive(false);
        Exit.SetActive(false);

    }
}
