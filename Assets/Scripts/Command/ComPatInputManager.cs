using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class acts as the invoker for our commands
public class ComPatInputManager : MonoBehaviour
{
    //Declaring the player we want the commands to act on
    public ComPatPlayer player;
    
    //Storing the commands with a corresponding key
    private Dictionary<KeyCode, Command> KeyComDict;

    //Define the user commands we want bound to keys
    private Command playerMoveFCommand;
    private Command playerMoveBCommand;
    private Command playerMoveLCommand;
    private Command playerMoveRCommand;

    private void Start()
    {
        KeyComDict = new Dictionary<KeyCode, Command>();

        //Creating commands
        playerMoveFCommand = new MoveFCommand(player);
        playerMoveBCommand = new MoveBCommand(player);
        playerMoveLCommand = new MoveLCommand(player);
        playerMoveRCommand = new MoveRCommand(player);
        //Binding default keys
        KeyComDict.Add(KeyCode.W, playerMoveFCommand);
        KeyComDict.Add(KeyCode.S, playerMoveBCommand);
        KeyComDict.Add(KeyCode.A, playerMoveLCommand);
        KeyComDict.Add(KeyCode.D, playerMoveRCommand);
        //Adding alternative keys - if needed
        //KeyComDict.Add(KeyCode.I, playerMoveFCommand);
        //KeyComDict.Add(KeyCode.K, playerMoveBCommand);
        //KeyComDict.Add(KeyCode.J, playerMoveLCommand);
        //KeyComDict.Add(KeyCode.L, playerMoveRCommand);
    }

    private void Update()
    {
        HandleInput();
    }

    //Invokes the command we want to execute
    private void HandleInput()
    {
        foreach (KeyCode key in KeyComDict.Keys)
        {
            if (Input.GetKey(key))
            {
                //Execute the command bound to the key
                KeyComDict[key].Execute();
            }
        }
    }

    //Converts char to keycode
    private KeyCode GetKeyCode(char character)
    {
        int alphaValue = (int)character;
        return (KeyCode)System.Enum.Parse(typeof(KeyCode), alphaValue.ToString());
    }

    //Rebinds existing function to new key
    private void RebindKey(InputField newKeyField, Command command)
    {
        //Haven't implemented a check for the string yet, so take first value
        KeyCode newKey = GetKeyCode(newKeyField.text[0]);

        foreach (KeyCode key in KeyComDict.Keys)
        {
            if (KeyComDict[key] == command)
            {
                KeyComDict.Remove(key);
                KeyComDict.Add(newKey, command);
                return;
            }
        }
    }

    public void RebindPlayerMoveForward (InputField newKeyField)
    {
        RebindKey(newKeyField, playerMoveFCommand);
    }

    public void RebindPlayerMoveBack(InputField newKeyField)
    {
        RebindKey(newKeyField, playerMoveBCommand);
    }

    public void RebindPlayerMoveLeft(InputField newKeyField)
    {
        RebindKey(newKeyField, playerMoveLCommand);
    }

    public void RebindPlayerMoveRight(InputField newKeyField)
    {
        RebindKey(newKeyField, playerMoveRCommand);
    }
}
