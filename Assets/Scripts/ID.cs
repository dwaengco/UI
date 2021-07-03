using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ID : MonoBehaviour
{
    public Text message;
    public Text result;
    public InputField inputField;
    public Button button;



    void Start()
    {
        SetFunction_UI();
    }

    //CodeFinder
    //From https://codefinder.janndk.com/
    private void SetFunction_UI()
    {
        //Reset
        ResetFunction_UI();

        button.onClick.AddListener(Function_Button);
        inputField.onValueChanged.AddListener(Function_InputField);
        inputField.onEndEdit.AddListener(Function_InputField_EndEdit);
    }

    private void Function_Button()
    {
        string txt = inputField.text;
        result.text = txt;
        Debug.LogError("InputField Result!\n" + txt);
    }
    private void Function_InputField(string _data)
    {
        string txt = _data;
        message.text = _data;
        Debug.Log("InputField Typing!\n" + _data);
    }
    private void Function_InputField_EndEdit(string _data)
    {
        string txt = _data;
        message.text = _data;
        Debug.LogError("InputField EndEdit!\n" + _data);
    }

    private void ResetFunction_UI()
    {
        button.onClick.RemoveAllListeners();
        inputField.placeholder.GetComponent<Text>().text = "Input..";
        inputField.onValueChanged.RemoveAllListeners();
        inputField.onEndEdit.RemoveAllListeners();
        inputField.contentType = InputField.ContentType.Standard;
        inputField.lineType = InputField.LineType.MultiLineNewline;

    }

    public void SceneChange()
    {
        SceneManager.LoadScene("third");

    }
}
