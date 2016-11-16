using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace MotifsGo
{
    public class SaveList
    {
        private static SaveList instance;

        public List<string> listSave = new List<string>();

        private SaveList() { }

        public static SaveList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaveList();
                }
                return instance;
            }
        }
    }
}
