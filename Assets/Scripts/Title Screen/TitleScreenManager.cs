using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace EldenRing
{
    public class TitleScreenManager : MonoBehaviour
    {
        public void StartNetworkAsHost()
        {
            NetworkManager.Singleton.StartHost();
        }

        public void StartNewGame()
        {
            StartCoroutine(WorldSaveGameManager.instance.LoadNewGame());
        }
    }
}
