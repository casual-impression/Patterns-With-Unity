using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cat : AnimalBase
{
    [SerializeField]
    private TextMeshProUGUI _text;

    void Awake() {
        startingPosition = this.transform.position;
        SetMoveBehaviour(new MoveBehaviourCat(this.transform, _speed, _text));
        SetSpeakBehaviour(new SpeakBehaviourCat(_text));
        behaviours = new Dictionary<string, System.Action>() {
            {"move", Move},
            {"move_speech", MoveMessage},
            {"speak", Speak}
        };
    }

    void OnMouseDown() {
        _text.gameObject.SetActive(true);
        _text.text = "Выбрано животное: " + this.name;
        PanelController.instance.Reset();
        PanelController.instance.curAnimalObj = this;
        PanelController.instance.behaviours = behaviours;
    }
}
