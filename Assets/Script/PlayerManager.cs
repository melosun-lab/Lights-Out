using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singloeton
        public PlayerManager instance;
        void Awake()
        {
            instance = this;
        }
    #endregion


    public GameObject player;
    
}
