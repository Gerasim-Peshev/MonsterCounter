using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using MonsterCounter2.Data.Models;

namespace MonsterCounter2.Services.Contract
{
    public interface IMonsterFanService
    {
        public Task<MonsterFan> GetMonsterFanByIdAsync(string userId);

        public Task EditMonsters(int normalGreen, int normalBlue, int theDoctor, int blueHamilton, int redHamilton,
                                 int noSugarGreen, int noSugarMango, int green, int orange, int normalMango, int pink,
                                 int pacificPunch, int khaotic, int java, int japanStrawberry, int molet, int assault,
                                 int white, int watermelon, int mixxd, int pinapple, string userId);
    }
}
