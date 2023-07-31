using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class MoveBehaviourCat: MoveBehaviourAbstract
{
    public MoveBehaviourCat(Transform startPosition, float moveStep, TextMeshProUGUI text) : 
    base(startPosition, moveStep, text) {}

    public override void Move() {
        PerformMovement((int)AnimalTypesEnum.Cat);
    }
    
    public override void MoveMessage() { ShowMessage(_text, AnimalTypesEnum.Cat); }
}