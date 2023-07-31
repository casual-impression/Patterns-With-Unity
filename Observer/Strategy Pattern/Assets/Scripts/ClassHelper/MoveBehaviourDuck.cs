using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class MoveBehaviourDuck: MoveBehaviourAbstract
{
    public MoveBehaviourDuck(Transform startPosition, float moveStep, TextMeshProUGUI text) : 
    base(startPosition, moveStep, text) {}

    public override void Move() {
        PerformMovement((int)AnimalTypesEnum.Duck);
    }
    
    public override void MoveMessage() { ShowMessage(_text, AnimalTypesEnum.Duck); }
}