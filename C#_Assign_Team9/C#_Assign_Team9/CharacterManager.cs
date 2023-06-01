using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assign_Team9
{
    internal class CharacterManager
    {
        public Character character1, character2;
        private static CharacterManager staticSingleton = null;

        public static CharacterManager Instance()
        {
            if(staticSingleton == null) 
            {
                staticSingleton = new CharacterManager();
            }
            return staticSingleton;
        }
    }
}
