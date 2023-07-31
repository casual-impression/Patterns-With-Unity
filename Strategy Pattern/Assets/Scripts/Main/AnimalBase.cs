using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class AnimalBase : MonoBehaviour
{
    protected AnimalBase() {
        //_speakBehaviour = new SpeakBehaviourNull(_text);
        //_moveBehaviour = new MoveBehaviourNull(this.transform, _speed, _text);
    }

    #region Variables
    protected Vector3 startingPosition;
    protected float _speed = 0.2f;
    protected float _timer = 4.0f;
    public Dictionary<string, System.Action> behaviours;
    protected ISpeak _speakBehaviour { get; set; }
    protected IMove _moveBehaviour { get; set; }
    #endregion

    #region SetInterfaces
    public void SetSpeakBehaviour(ISpeak newSound) {
        _speakBehaviour = newSound;
    }
    public void SetMoveBehaviour(IMove newMoveType) {
        _moveBehaviour = newMoveType;
    }
    #endregion

    #region BaseMethods
    public void Speak() {
        _speakBehaviour.Speak();
    }
    public void Move() {
        _moveBehaviour.Move();
    }
    public void MoveMessage() {
        _moveBehaviour.MoveMessage();
    }
    public void ResetPosition()
    {
        this.transform.position = startingPosition;
    }
    #endregion
}
