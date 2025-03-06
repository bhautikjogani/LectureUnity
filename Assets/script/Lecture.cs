using Unity.VisualScripting;
using UnityEngine;

public class Lecture : MonoBehaviour
{

    private void Awake()
    {
        print("Awake");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    private void Start()
    {
        print("Start");
    }

    private void Update()
    {
        print("Update");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnDestroy()
    {
        print("OnDestroy");
    }

}
