using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Abstract
{
    interface IVerificationService
    {
        bool Verifaction(Gamer gamer);
    }
}
