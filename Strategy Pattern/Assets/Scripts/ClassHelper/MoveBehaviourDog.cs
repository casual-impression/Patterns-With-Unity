using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class MoveBehaviourDog: MoveBehaviourAbstract
{
    public MoveBehaviourDog(Transform startPosition, float moveStep, TextMeshProUGUI text) : 
    base(startPosition, moveStep, text) {}

    public override void Move() {
        PerformMovement((int)AnimalTypesEnum.Dog);
    }
    
    public override void MoveMessage() { ShowMessage(_text, AnimalTypesEnum.Dog); }
}