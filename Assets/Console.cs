using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour {

    public Canvas consoleCanvas;        //Console canvas
    public Text consoleText;            //Text in the scroll view
    public Text inputText;              //Input Text
    public InputField consoleInput;     //Input entered by user through command
    public GameObject consoleMenu;
    public string[] commands;
    public Camera cam;
    public AIController ai;

    // Use this for initialization
    void Start () {
        commands = new string[] { "red", "green", "blue" };
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            consoleCanvas.gameObject.SetActive(!consoleCanvas.gameObject.activeInHierarchy);
        }

        if (consoleCanvas.gameObject.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (inputText.text != "")
                {
                    AddMessageToConsole(inputText.text);
                    ParseInput(inputText.text);
                }
            }
        }
    }

    private void AddMessageToConsole(string msg)
    {
        consoleText.text += msg + "\n";
    }

    private void ParseInput(string input)
    {
        string[] _input = input.Split(null);
        Debug.Log("_input:" + _input[0]);

        if (_input.Length == 0 || _input == null)
        {
            consoleText.text += "Command not recognized\n";
        }
        Debug.Log("Passed null test");

        if (_input.Length == 2)
        {
            if (_input[0] == commands[0])
            {
                cam.backgroundColor = Color.red;
                consoleText.text += "Background set to red\n";
            }
            else if (_input[0] == commands[1])
            {
                cam.backgroundColor = Color.green;
                consoleText.text += "Background set to green\n";
            }
            else if (_input[0] == commands[2])
            {
                cam.backgroundColor = Color.blue;
                consoleText.text += "Background set to blue\n";
            } else if (_input[0] == "ai")
            {
                if (_input[1] == "easy")
                {
                    ai.skill = 0.025f;
                    consoleText.text += "AI set to easy\n";
                } else if (_input[1] == "hard")
                {
                    ai.skill = 0.04f;
                    consoleText.text += "AI set to hard\n";
                }
            } else
            {
                consoleText.text += "Command not recognized\n";
            }
        }
        else
        {
            consoleText.text += "Command not recognized\n";
        }
    }

}
