using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
public class ArraysDataSimple : MonoBehaviour
{
    [SerializeField] TMP_InputField _inputField;

    int[] _intArray = new int[100];
    int _nElemts = 0;
    int _jCounter;

    void Start()
    {
        _nElemts = _intArray.Length;

        FillArray();
    }

    void Update()
    {
        foreach (var currentElement in _intArray)
        {
            if (currentElement == int.Parse(_inputField.text))
                Debug.Log(currentElement);
        }
    }

    void FillArray()
    {
        for (_jCounter = 0; _jCounter < _nElemts; _jCounter++)
        {
            _intArray[_jCounter] = Random.Range(1, 100);
        }

        _intArray[0] = 999;
    }
}