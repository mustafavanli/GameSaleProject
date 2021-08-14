using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class VerifactionManager : IVerificationService
    {
        public bool Verifaction(Gamer gamer)
        {
            if (gamer.IdentityNumber.ToString().Length == 9) // 9 HANELİ İSE TRUE DÖNDÜRÜYOR...
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
