using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartRaceManager : MonoBehaviour
{
    public TextMeshProUGUI readyText;
    public TextMeshProUGUI goText;

    public Button startButton;

    private float raceStartDelay = 4f;
    private float disableGoTextDelay = 2.5f;

    public PitStopController pitStopController;

    void Start()
    {
        pitStopController = GameObject.FindObjectOfType<PitStopController>();
    }

    public void StartGame()
    {
        startButton.gameObject.SetActive(false);
        readyText.gameObject.SetActive(true);
        StartCoroutine(RaceStart());
    }

    IEnumerator RaceStart()
    {
        yield return new WaitForSeconds(raceStartDelay);
        readyText.gameObject.SetActive(false);
        goText.gameObject.SetActive(true);
        pitStopController.raceStarted = true;
        Debug.Log("Race Has Started");
        StartCoroutine(DisableGoText());
    }

    IEnumerator DisableGoText()
    {
        yield return new WaitForSeconds(disableGoTextDelay);
        goText.gameObject.SetActive(false);
    }
}
