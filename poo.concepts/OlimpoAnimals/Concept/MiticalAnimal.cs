using System;
using System.Collections.Generic;
using System.Text;

namespace poo.concepts.OlimpoAnimals.Concept
{
    //this is an ABSTRACT concept, because we need to derive in other clases
    public abstract class MiticalAnimal
    {
        private string NickName { get; set; }
        public void SetNickname(string nickName) => NickName = nickName;
        public string GetNickname() => NickName;

        //need to provide an implementation inderived classes
        public abstract string GetMiticalSound();

    }
}
