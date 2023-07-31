using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class MoveBehaviourNull: MoveBehaviourAbstract
{
    public MoveBehaviourNull(Transform startPosition, float moveStep, TextMeshProUGUI text) : 
    base(startPosition, moveStep, text) {}

    public override void Move() {}
    public override void MoveMessage() { ShowMessage(_text, AnimalTypesEnum.Carrot); }
}