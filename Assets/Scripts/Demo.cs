using UnityEngine;

public class Demo : MonoBehaviour {
    [SerializeField] Timer timer1;
    [SerializeField] Timer timer2;
    [SerializeField] Timer timer3;
    [SerializeField] Timer timer4;

    private void Start() {
        timer1
        .SetDuration(6)
        .OnEnd(() => Debug.Log("Timer1 ended"))
        .Begin();

        timer2
        .SetDuration(10)
        .OnEnd(() => Debug.Log("Timer2 ended"))
        .Begin();

        timer3
        .SetDuration(15)
        .OnEnd(() => Debug.Log("Timer3 ended"))
        .Begin();

        timer4
        .SetDuration(25)
        .OnEnd(() => Debug.Log("Timer4 ended"))
        .Begin();
    }

    private void Update() {
        if (Input.GetKeyUp("p"))
            timer1.SetPaused(!timer1.IsPaused);
    }
}
