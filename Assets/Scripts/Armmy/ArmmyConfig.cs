using System;
using UnityEngine;

namespace Armmy
{
    [Serializable]
    public class ArmmyConfig
    {
        [SerializeField]
        GameObject solder = null;
        public GameObject Solder => this.solder;

        [SerializeField,Range(0,100)]
        int menber = 0;
        public int Menber => this.menber;
    }
}
