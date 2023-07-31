using TMPro;
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class SpeakBehaviourAbstract: ISpeak {
    protected static Dictionary<AnimalTypesEnum, string> TypeSoundPair = new Dictionary<AnimalTypesEnum, string>();
    internal TextMeshProUGUI _text;

    public SpeakBehaviourAbstract(TextMeshProUGUI text) {
        _text = text;
        SetupDictionary();
    }

    private void SetupDictionary() {
        if (!TypeSoundPair.Keys.Contains(AnimalTypesEnum.Null)) {
            TypeSoundPair.Add(AnimalTypesEnum.Null, "...");
            TypeSoundPair.Add(AnimalTypesEnum.Carrot, "Я умею имитировать человеческую речь");
            TypeSoundPair.Add(AnimalTypesEnum.Cat, "Мяу-мяу. Мяукаю я!");
            TypeSoundPair.Add(AnimalTypesEnum.Dog, "Гав-гав. Рррр...");
            TypeSoundPair.Add(AnimalTypesEnum.Duck, "Кря-кря. Я уточка.");
        }
    }

    public abstract void Speak();

    protected void ShowMessage(TextMeshProUGUI text, AnimalTypesEnum animalType) {
        text.gameObject.SetActive(true);
        text.text = TypeSoundPair[animalType];
    }
}