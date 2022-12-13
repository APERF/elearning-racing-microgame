using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionHandlerOne : MonoBehaviour
{
    private float questionDelay = 10f;

    public Button openTrackTwo;
    public Button openTrackThree;
    public Button openTrackFour;
    public Button openTrackFive;

    public PitStopController pitStopController;

    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Game Exited");
        }
    }

    public void OpenQuestionOne()
    {
        Application.OpenURL("https://www.google.com");
        StartCoroutine(QuestionOneContinue());
    }

    IEnumerator QuestionOneContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackTwo.gameObject.SetActive(true);
    }

    public void OpenTrackTwo()
    {
        SceneManager.LoadScene(5);
    }

    public void OpenQuestionTwo()
    {
        Application.OpenURL("https://forum.unity.com/threads/unity-is-the-most-frustrating-platform-ever.710792/");
        StartCoroutine(QuestionTwoContinue());
    }

    IEnumerator QuestionTwoContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackThree.gameObject.SetActive(true);
    }

    public void OpenTrackThree()
    {
        SceneManager.LoadScene(7);
    }

    public void OpenQuestionThree()
    {
        Application.OpenURL("https://gamedevacademy.org/unity-vs-unreal/");
        StartCoroutine(QuestionThreeContinue());
    }

    IEnumerator QuestionThreeContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackFour.gameObject.SetActive(true);
    }

    public void OpenTrackFour()
    {
        SceneManager.LoadScene(9);
    }

    public void OpenQuestionFour()
    {
        Application.OpenURL("https://media.cnn.com/api/v1/images/stellar/prod/221130093222-09-mauna-loa-eruption-gallery.jpg?c=original");
        StartCoroutine(QuestionFourContinue());
    }

    IEnumerator QuestionFourContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackFive.gameObject.SetActive(true);
    }

    public void OpenTrackFive()
    {
        SceneManager.LoadScene(11);
    }

    public void OpenQuestionFive()
    {
        Application.OpenURL("https://www.reddit.com/r/Unity3D/comments/begito/sorry_but_unity_is_indeed_garbage/");
        StartCoroutine(QuestionFiveContinue());
    }

    IEnumerator QuestionFiveContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackFive.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(13);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void MenuStart()
    {
        SceneManager.LoadScene(1);
    }

    public void NextInstructions()
    {
        SceneManager.LoadScene(2);
    }

    public void StartFromInstruction()
    {
        SceneManager.LoadScene(3);
        pitStopController.raceStarted = false;
    }
}
