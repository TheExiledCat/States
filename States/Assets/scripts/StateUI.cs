
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StateUI : MonoBehaviour
{
    public TextMeshPro t;
    StateMachine s;
    void Awake()
    {
        s = GetComponent<StateSystem>().smc;
        s.OnChangeState += Change;
    }
    // Start is called before the first frame update
    void Change(){
        t.text = "Current state:" + "\n" + s.currentState.ToString();
    }
}
