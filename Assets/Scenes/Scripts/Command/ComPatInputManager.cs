using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class acts as the invoker for our commands
public class ComPatInputManager : MonoBehaviour
{
    //Declaring the player we want the commands to act on
    public ComPatPlayer player;
    
    //Storing the commands with a corresponding key
    private Dictionary<KeyCode, Command> KeyComDict;

    private Command playerMoveFCommand;
    private Command playerMoveBCommand;
    private Command playerMoveLCommand;
    private Command playerMoveRCommand;

    private void Start()
    {
        KeyComDict = new Dictionary<KeyCode, Command>();

        //Creating commands - passing the player in as a receiver
        playerMoveFCommand = new MoveFCommand(player);
        playerMoveBCommand = new MoveBCommand(player);
        playerMoveLCommand = new MoveLCommand(player);
        playerMoveRCommand = new MoveRCommand(player);
        //Base keys
        KeyComDict.Add(KeyCode.W, playerMoveFCommand);
        KeyComDict.Add(KeyCode.S, playerMoveBCommand);
        KeyComDict.Add(KeyCode.A, playerMoveLCommand);
        KeyComDict.Add(KeyCode.D, playerMoveRCommand);
        //Adding alternative keys
        KeyComDict.Add(KeyCode.I, playerMoveFCommand);
        KeyComDict.Add(KeyCode.K, playerMoveBCommand);
        KeyComDict.Add(KeyCode.J, playerMoveLCommand);
        KeyComDict.Add(KeyCode.L, playerMoveRCommand);
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
}
