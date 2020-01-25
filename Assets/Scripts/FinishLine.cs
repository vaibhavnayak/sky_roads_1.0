using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter() => gm.LevelComplete();
}
