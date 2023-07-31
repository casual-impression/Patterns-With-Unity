using TMPro;

public class SpeakBehaviourNull: SpeakBehaviourAbstract
{

    public SpeakBehaviourNull(TextMeshProUGUI text): base(text) {}

    public override void Speak() {
        ShowMessage(_text, AnimalTypesEnum.Null);
    }
}