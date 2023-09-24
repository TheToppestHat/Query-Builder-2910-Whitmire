using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.QueryBuilderStarterKit
{
    internal class Pokemon : IClassModel
    {

        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string? Form { get; set; }
        public string? Type1 { get; set; }
        public string? Type2 { get; set; }
        public int? Total { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }

        public Pokemon() { }
        public Pokemon(int id,int dexnumber, string name, string? form, string? type1, string? type2, int? total, int hp, int attack, int defense, int specialattack, int specialdefense, int speed, int generation)
        {
            Id = id;
            DexNumber = dexnumber;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialattack;
            SpecialDefense = specialdefense;
            Speed = speed;
            Generation = generation;
        }

        public override string ToString()
        {
            string msg = $"\nPokeDex #: {Id}\nPokemon: {Name}\nForm(if applicable): {Form}\nGeneration: {Generation}\nType: {Type1}\nSecondary Type(if applicable): {Type2}\nTotal:{Total}\nHp: {Hp},Attack: {Attack},Defence: {Defense}\nSpecial Attack: {SpecialAttack},Special Defence: {SpecialDefense},Speed: {Speed}\n\n\n";
            return msg;
        }
    }
}

