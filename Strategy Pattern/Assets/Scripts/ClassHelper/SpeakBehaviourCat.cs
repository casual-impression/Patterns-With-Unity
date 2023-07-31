using TMPro;

public class SpeakBehaviourCat: SpeakBehaviourAbstract {
    public SpeakBehaviourCat(TextMeshProUGUI text): base(text) {}
    
    public override void Speak() {
        ShowMessage(_text, AnimalTypesEnum.Cat);
    }
}