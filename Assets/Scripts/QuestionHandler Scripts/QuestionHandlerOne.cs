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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
