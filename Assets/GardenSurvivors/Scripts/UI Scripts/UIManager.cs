using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private LoseScreen loseScreen;
    [SerializeField] private HealthUpdate healthUpdate;
    [SerializeField] private GameObject[] screens;
    [SerializeField] private GameObject canvas;
    [SerializeField] private Score _score;

    public void SetScore(int valueToShow) {
        _score.Set(valueToShow);
    }

    public void ShowLoseScreen() {
        //loseScreen.gameObject.SetActive(true);

        GameObject lose = screens[Random.Range(0, screens.Length)];
        GameObject screen = Instantiate(lose);
        screen.transform.SetParent(canvas.transform);
        screen.transform.position = canvas.transform.position;
        screen.SetActive(true);
    }

    public void UpdateHealth(float health) {
        healthUpdate.UpdateHealth(health);
    }


}
