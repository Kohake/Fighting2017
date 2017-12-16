using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    abstract class Character
    {
        // This is the character, static stuff for menues and also the instance I think.
        protected BattleAvatar namn;

        public enum CharacterIndex
        {
            ThatGuy,

            Size
        }

        public static BattleAvatar CreateBattleAvatar(CharacterIndex characterIndex)
        {
            return characterDictionary[characterIndex]();
        }

        private delegate BattleAvatar CharacterCreationFunction();
        private static Dictionary<CharacterIndex, CharacterCreationFunction> characterDictionary = new Dictionary<CharacterIndex, CharacterCreationFunction>()
        {
            // () => { }  is a lambda, a way to create an inline anonym(???) function
            { CharacterIndex.ThatGuy, () => { return new Avatars.ThatGuy(); } },
            //{ CharacterIndex.Size, () => { return new SizeGuy(); } }
        };
    }
}
