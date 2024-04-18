using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterCounter2.Data.Models
{
    public class MonsterFan : IdentityUser
    {
        public MonsterFan()
        {
            this.NormalGreen = 0;
            this.NormalBlue = 0;
            this.TheDoctor = 0;
            this.BlueHamilton = 0;
            this.RedHamilton = 0;
            this.NoSugarGreen = 0;
            this.NoSugarMango = 0;
            this.Green = 0;
            this.Orange = 0;
            this.NormalMango = 0;
            this.Pink = 0;
            this.PacificPunch = 0;
            this.Khaotic = 0;
            this.Java = 0;
            this.JapanStrawberry = 0;
            this.Molet = 0;
            this.Assault = 0;
            this.White = 0;
            this.Watermelon = 0;
            this.Mixxd = 0;
            this.Pinapple = 0;
        }

     
        public int NormalGreen { get; set; }
        public int NormalBlue { get; set; }
        public int TheDoctor { get; set; }
        public int BlueHamilton { get; set; }
        public int RedHamilton { get; set; }
        public int NoSugarGreen { get; set; }
        public int NoSugarMango { get; set; }
        public int Green { get; set; }
        public int Orange { get; set; }
        public int NormalMango { get; set; }
        public int Pink { get; set; }
        public int PacificPunch { get; set; }
        public int Khaotic { get; set; }
        public int Java { get; set; }
        public int JapanStrawberry { get; set; }
        public int Molet { get; set; }
        public int Assault { get; set; }
        public int White { get; set; }
        public int Watermelon { get; set; }
        public int Mixxd { get; set; }
        public int Pinapple { get; set; }
        public int TotalSum
        {
            get
            {
                return NormalGreen + NormalBlue + TheDoctor + BlueHamilton +
                       RedHamilton + NoSugarGreen + NoSugarMango + Green +
                       Orange + NormalMango + Pink + PacificPunch + Khaotic +
                       Java + JapanStrawberry + Molet + Assault + White +
                       Watermelon + Mixxd + Pinapple;
            }
        }
    }
}
