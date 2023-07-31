using TMPro;

public class SpeakBehaviourDuck: SpeakBehaviourAbstract 
{
    public SpeakBehaviourDuck(TextMeshProUGUI text): base(text) {}

    public override void Speak() {
        ShowMessage(_text, AnimalTypesEnum.Duck);
    }
}