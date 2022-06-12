using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOtNetRPG.Models;

namespace DOtNetRPG.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}