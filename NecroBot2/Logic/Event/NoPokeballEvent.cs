﻿#region using directives

using POGOProtos.Enums;

#endregion

namespace NecroBot2.Logic.Event
{
    public class NoPokeballEvent : IEvent
    {
        public int Cp;
        public PokemonId Id;
    }
}