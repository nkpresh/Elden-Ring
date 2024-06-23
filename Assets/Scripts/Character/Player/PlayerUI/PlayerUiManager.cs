using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace EldenRing
{
    public class PlayerUiManager : MonoBehaviour
    {
        public static PlayerUiManager instance;

        [Header("NETWORK JOIN")]
        [SerializeField]
        bool startGameAsClient;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            if (startGameAsClient)
            {
                startGameAsClient = false;
                NetworkManager.Singleton.Shutdown();
                NetworkManager.Singleton.StartClient();
            }
        }
    }
}
