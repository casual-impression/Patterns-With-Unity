using TMPro;

public class SpeakBehaviourDog: SpeakBehaviourAbstract, ISpeak {

    public SpeakBehaviourDog(TextMeshProUGUI text): base(text) {}

    public override void Speak() {
        ShowMessage(_text, AnimalTypesEnum.Dog);
    }
}