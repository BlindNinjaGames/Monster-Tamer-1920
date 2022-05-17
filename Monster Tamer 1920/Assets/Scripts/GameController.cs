using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Battle, Dialog, Menu, PartyScreen, Bag, Cutscene, Paused, GeneralShop }

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    GameState state;

    private void Update()
    {
        if(state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        }
    }
}
