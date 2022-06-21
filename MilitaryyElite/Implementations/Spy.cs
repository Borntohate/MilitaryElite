﻿using MilitaryyElite.Interfaces;
using System.Collections.Generic;

namespace MilitaryyElite.Implementations
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get ; set ; }
    }
}