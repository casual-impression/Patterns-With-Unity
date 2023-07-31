using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System;

public class MoveBehaviourCarrot: MoveBehaviourAbstract
{
    public MoveBehaviourCarrot(Transform startPosition, float moveStep, TextMeshProUGUI text) : 
    base(startPosition, moveStep, text) {}

    public override void Move() {
        PerformMovement((int)AnimalTypesEnum.Carrot);
    }

    public override void MoveMessage() { ShowMessage(_text, AnimalTypesEnum.Carrot); }
}