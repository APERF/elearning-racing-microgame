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
        SceneManager.LoadScene(2);
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
        SceneManager.LoadScene(4);
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
        SceneManager.LoadScene(6);
    }

    public void OpenQuestionFour()
    {
        Application.OpenURL("https://media.cnn.com/api/v1/images/stellar/prod/221130093222-09-mauna-loa-eruption-gallery.jpg?c=original");
        StartCoroutine(QuestionFourContinue());
    }

    IEnumerator QuestionFourContinue()
    {
        yield return new WaitForSeconds(questionDelay);
        openTrackFour.gameObject.SetActive(true);
    }

    public void OpenTrackFive()
    {
        SceneManager.LoadScene(8);
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
        SceneManager.LoadScene(10);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
