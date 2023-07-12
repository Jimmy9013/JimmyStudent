using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameMain
{
    public partial class GameEntry : MonoBehaviour
    {
        private void Start()
        {
            InitBuiltinComponents();
            InitCustomComponents();
        }
    }
}

