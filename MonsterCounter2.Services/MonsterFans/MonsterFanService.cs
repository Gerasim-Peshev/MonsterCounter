using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MonsterCounter2.Data;
using MonsterCounter2.Data.Models;
using MonsterCounter2.Services.Contract;

namespace MonsterCounter2.Services.MonsterFans
{
    public class MonsterFanService : IMonsterFanService
    {
        private readonly MonsterCounter2DbContext context;


        public MonsterFanService(MonsterCounter2DbContext data)
        {
            this.context = data;
        }
        public async Task<MonsterFan> GetMonsterFanByIdAsync(string userId)
        {
            return await context.Users.FirstOrDefaultAsync(
                u => u.Id.ToString().ToLower() == userId.ToLower());
        }

        public async Task EditMonsters(int normalGreen, int normalBlue, int theDoctor, int blueHamilton,
                                       int redHamilton, int noSugarGreen,
                                       int noSugarMango, int green, int orange, int normalMango, int pink,
                                       int pacificPunch, int khaotic,
                                       int java, int japanStrawberry, int molet, int assault, int white, int watermelon,
                                       int mixxd,
                                       int pinapple, string userId)
        {
            var userrr = await GetMonsterFanByIdAsync(userId);

            if (userrr != null)
            {
                userrr.NormalGreen = normalGreen;
                userrr.NormalBlue = normalBlue;
                userrr.TheDoctor = theDoctor;
                userrr.BlueHamilton = blueHamilton;
                userrr.RedHamilton = redHamilton;
                userrr.NoSugarGreen = noSugarGreen;
                userrr.NoSugarMango = noSugarMango;
                userrr.Green = green;
                userrr.Orange = orange;
                userrr.NormalMango = normalMango;
                userrr.Pink = pink;
                userrr.PacificPunch = pacificPunch;
                userrr.Khaotic = khaotic;
                userrr.Java = java;
                userrr.JapanStrawberry = japanStrawberry;
                userrr.Molet = molet;
                userrr.Assault = assault;
                userrr.White = white;
                userrr.Watermelon = watermelon;
                userrr.Mixxd = mixxd;
                userrr.Pinapple = pinapple;

                await context.SaveChangesAsync();
            }
        }
    }
}
