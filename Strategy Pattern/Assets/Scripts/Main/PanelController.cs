using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class PanelController : MonoBehaviour {
    public static PanelController instance;
    public AnimalBase curAnimalObj;
    public Dictionary<string, System.Action> behaviours;

    [SerializeField]
    private TextMeshProUGUI text;

    private bool IsMoving = false;
    private float timer = 0.0f;

    private void Awake() {
        instance = this;
    }

    public void Reset() {
        IsMoving = false;
        timer = 0.0f;
    }

    public void SpeakButton() {
        try {
            if (behaviours.Keys.Contains("speak")) {
                behaviours["speak"].Invoke();
            }
        }
        catch (System.Exception) {
            StartCoroutine(ShowErrorMessage("Животное не выбрано. Мне сказать нечего.", 2.0f));
        }
        
    }

    public void ResetPositionButton() {
        try {
            curAnimalObj.ResetPosition();
        }
        catch (System.Exception) {
            StartCoroutine(ShowErrorMessage("Животное не выбрано. Некуда возвращаться.", 3.0f));
        }
    }

    public void MoveButton() {
        try {
            if (behaviours.Keys.Contains("move")) {
                IsMoving = true;
            }
            if (behaviours.Keys.Contains("move_speech")) {
                behaviours["move_speech"].Invoke();
            }
        }
        catch (System.Exception) {
            StartCoroutine(ShowErrorMessage("Животное не выбрано. Движение не может быть начато.", 4.0f));
        }
    }

    private void Update() {
        if (timer < 2) {
            timer += Time.deltaTime;
            if (IsMoving) {
                behaviours["move"].Invoke();
            }
        }
    }

    IEnumerator ShowErrorMessage(string messageToShow, float timeToSee) {
        text.gameObject.SetActive(true);
        text.text = messageToShow;
        yield return new WaitForSeconds(timeToSee);
        text.gameObject.SetActive(false);
    }
}