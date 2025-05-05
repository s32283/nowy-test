using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public string Word = "after";
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI OurInput;
    public TMP_InputField InputField;
    public 

    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
    }
        public void OnInputChanged(string input)
    {
        OurInput.text = input;

    }

    public void OnClick(string input)
    {


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
