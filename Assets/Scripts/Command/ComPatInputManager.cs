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
    private Dictionary<KeyCode, Command> keyComDict;

    //Define the user commands we want bound to keys
    private Command playerMoveFCommand;
    private Command playerMoveBCommand;
    private Command playerMoveLCommand;
    private Command playerMoveRCommand;

    //Command stack that undoes the commands of the player
    //Would need to make a list if we wanted to redo as well
    private Stack<Command> comStack;

    private void Start()
    {
        keyComDict = new Dictionary<KeyCode, Command>();
        comStack = new Stack<Command>();

        //Creating commands
        playerMoveFCommand = new MoveFCommand(player);
        playerMoveBCommand = new MoveBCommand(player);
        playerMoveLCommand = new MoveLCommand(player);
        playerMoveRCommand = new MoveRCommand(player);
        //Binding default keys
        keyComDict.Add(KeyCode.W, playerMoveFCommand);
        keyComDict.Add(KeyCode.S, playerMoveBCommand);
        keyComDict.Add(KeyCode.A, playerMoveLCommand);
        keyComDict.Add(KeyCode.D, playerMoveRCommand);
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
        foreach (KeyCode key in keyComDict.Keys)
        {
            if (Input.GetKey(key))
            {
                //Execute the command bound to the key
                keyComDict[key].Execute();
                //Add the command to the stack
                comStack.Push(keyComDict[key]);
            } else if (Input.GetKey(KeyCode.U) && comStack.Count != 0)
            {
                comStack.Pop().Undo();
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

        foreach (KeyCode key in keyComDict.Keys)
        {
            if (keyComDict[key] == command)
            {
                keyComDict.Remove(key);
                keyComDict.Add(newKey, command);
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
