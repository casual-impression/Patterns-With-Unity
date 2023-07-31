using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Linq;

public abstract class MoveBehaviourAbstract: IMove 
{
    protected static Dictionary<AnimalTypesEnum, string> TypeMessagePair = new Dictionary<AnimalTypesEnum, string>();
    internal Transform _startPosition;
    internal float _moveSpeed;
    internal TextMeshProUGUI _text;

    public MoveBehaviourAbstract(Transform startPosition, float moveSpeed, TextMeshProUGUI text) 
    {
        _startPosition = startPosition;
        _moveSpeed = moveSpeed;
        _text = text;

        SetupDictionary();
    }
    private void SetupDictionary() {
        if (!TypeMessagePair.Keys.Contains(AnimalTypesEnum.Null)) {
            TypeMessagePair.Add(AnimalTypesEnum.Null, "...");
            TypeMessagePair.Add(AnimalTypesEnum.Carrot, "Я иду на двух лапах.");
            TypeMessagePair.Add(AnimalTypesEnum.Cat, "Я двигаюсь на четырех лапках.");
            TypeMessagePair.Add(AnimalTypesEnum.Dog, "Я передвигаюсь на 4 лапах.");
            TypeMessagePair.Add(AnimalTypesEnum.Duck, "Я двигаю маленькими ножками.");
        }
    }

    public abstract void Move();
    public abstract void MoveMessage();
    protected void ShowMessage(TextMeshProUGUI text, AnimalTypesEnum animalType) {
        text.gameObject.SetActive(true);
        text.text = TypeMessagePair[animalType];
    }

    protected void PerformMovement(int scaleFactor) {
        _startPosition.position += Vector3.forward * _moveSpeed * scaleFactor * 0.05f;
    }
}