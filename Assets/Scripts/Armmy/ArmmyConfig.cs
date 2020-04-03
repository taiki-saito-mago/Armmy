using System;
using UnityEngine;
namespace Armmy
{
    [Serializable]
    public class ArmmyConfig
    {
        [SerializeField]
        GameObject soldir = null;
        public GameObject Soldir => this.soldir;

        [SerializeField,Range(1,100)]
        int menber = 0;
        public int Member => this.menber;
    }
}
