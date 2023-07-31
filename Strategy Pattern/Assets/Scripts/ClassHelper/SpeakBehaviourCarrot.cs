using TMPro;

public class SpeakBehaviourCarrot: SpeakBehaviourAbstract, ISpeak {
    public SpeakBehaviourCarrot(TextMeshProUGUI text): base(text) {}
    
    public override void Speak() {
        ShowMessage(_text, AnimalTypesEnum.Carrot);
    }
}