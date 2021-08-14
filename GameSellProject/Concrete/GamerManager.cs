using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GamerManager : IGamerService
    {
        IVerificationService _verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }
        public void Add(Gamer gamer)
        {
            if (_verificationService.Verifaction(gamer))
            {
                Console.WriteLine(gamer.FirstName + " oyuncu başarıyla giriş yaptı");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, lütfen tekrar deneyiniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silinmiştir " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncunun bilgileri güncellenmiştir");
        }
    }
}
