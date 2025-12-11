using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounterVisual : MonoBehaviour
{
    [SerializeField] private GameObject stoveOnGameObject;
    [SerializeField] private GameObject particalesGameObject;
    [SerializeField] private StoveCounter stoveCounter;

    private void Start()
    {
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        bool isIdle = e.state == StoveCounter.States.Idle;
        bool isFrying = e.state == StoveCounter.States.Frying;
        stoveOnGameObject.SetActive(!isIdle);

        particalesGameObject.SetActive(!isFrying && !isIdle);


    }
}
