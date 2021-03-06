﻿using UnityEngine;

namespace Children
{
    public class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject("Children maker");

            _go.AddComponent<ChildrenMaker>();
        }
        
        public void onDisabled()
        {
            Object.Destroy(_go);
        }

        public string Name { get { return "Children maker"; } }
        public string Description { get { return "Makes children (pun intended)"; } }
        public string Identifier { get; set; }
    }
}
