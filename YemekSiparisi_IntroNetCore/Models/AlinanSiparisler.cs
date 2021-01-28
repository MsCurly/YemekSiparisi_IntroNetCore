using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YemekSiparisi_IntroNetCore.Models
{
    public static class AlinanSiparisler
    {
        public static List<KullaniciGirisi> incomingUsers = new List<KullaniciGirisi>();
        public static void Add(KullaniciGirisi kullaniciGirisi)
        {
            incomingUsers.Add(kullaniciGirisi);
        }

    }
}