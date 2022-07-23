using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlTimer : MonoBehaviour
{
    public Text timerText;
    static float timer;
    public Text bestText;
    public Button btn;

    void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Track");
    }

    void Update()
    {
        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

        string time = string.Format("{0:0}:{1:00}", minutes, seconds);

        timerText.text = time;

        if (Input.GetKeyDown("r"))
        {
            RestartGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bestText.text = "Finish: " + timerText.text;
        btn.gameObject.SetActive(true);
    }
}
