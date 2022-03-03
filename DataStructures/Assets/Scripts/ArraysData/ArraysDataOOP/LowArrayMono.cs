using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class LowArrayMono : MonoBehaviour
{
    [SerializeField] TMP_InputField _inputField;
    
    LowArray _lowArray = new LowArray(100);
    
    int _counter;
    
    void Start()
    {
       FillData(); 
    }

    void Update()
    {
        var tryParseValue = int.TryParse(_inputField.text, out var result);
        _lowArray.SearchForElement(result);
        
        _lowArray.DeleteElement(10, _counter);
    }

    void FillData()
    {
        for (_counter = 0; _counter < _lowArray.GetLength(); _counter++)
        {
            _lowArray.SetElement(_counter,Random.Range(1, 100));
        }
    }
    
}
