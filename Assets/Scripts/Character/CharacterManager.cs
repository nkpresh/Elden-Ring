using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EldenRing
{
    public class CharacterManager : MonoBehaviour
    {
        // Start is called before the first frame update
        protected virtual void Awake()
        {
            DontDestroyOnLoad(this);
        }

        // Update is called once per frame
        protected virtual void Update()
        {

        }
    }
}
