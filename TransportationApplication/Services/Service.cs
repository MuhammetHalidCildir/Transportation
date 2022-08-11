using Base.IService;
using Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationApplication.Services
{
    public class Service : IService
    {
        public string AddMoneyToAnoymousCard(decimal money, AnonymousCard anonymousCard)
        {
            anonymousCard.Money +=money;
            return $"Kartınıza {money} tl yüklenmiştir. Yeni bakiyeniz= {anonymousCard.Money} ";
        }

        public string AddMoneyToPrivateCard(decimal money, PrivateCard privateCard)
        {
            privateCard.Money += money;
            return $"Kartınıza {money} tl yüklenmiştir. Yeni bakiyeniz= {privateCard.Money} ";
        }

        public string CardControl()
        {
            AnonymousCard card1 = new AnonymousCard { Id = 1, CardId = 1234567891234567, Money = 100, SpecialDiscount = false };

            PrivateCard card2 = new PrivateCard { Id = 2, CardId = 1234567891234456, Name = "yolcu", Surname = "yolcuoglu", Tc_Num = 25184615895, Is_Student = true, Money = 0,  };

            PrivateCard card3 = new PrivateCard { Id = 3, CardId = 1234567891234498, Name = "Muhammed", Surname = "Çıldır", Tc_Num = 25184615843, Is_OlderThanSixty = true, Money = 6 };

            PrivateCard card4 = new PrivateCard { Id = 4, CardId = 1234567891234456, Name = "Mahmut", Surname = "mahmutoglu", Tc_Num = 18884615895, Is_Worker = true, Money = 4 };

            PrivateCard card5 = new PrivateCard { Id = 5, CardId = 1554567891234456, Name = "Ebrar", Surname = "Karakurt", Tc_Num = 96384615895, Is_Student = true, Money = 7 };

            PrivateCard card6 = new PrivateCard { Id = 6, CardId = 6587567891234456, Name = "Saim", Surname = "Güneş", Tc_Num = 76314615895, Is_Worker = true, Money = 18 };

            AnonymousCard card7 = new AnonymousCard { Id = 7, CardId = 1234567891234567, Money = 100, SpecialDiscount = false };

            var all_Cards = new List<BaseCard>() { card1, card2, card3, card4, card5, card6, card7 };
            //indirimsiz kartlar için
            var private_Card_List = new List<PrivateCard>() { card2, card3, card4, card5, card6 };

            Console.WriteLine("Lütfen Kartınızın Id Numarasını Giriniz");
            var ıd = Convert.ToInt32(Console.ReadLine());
            var card = all_Cards.FirstOrDefault(x => x.Id == ıd);
            var basePrice = 7;
            if (card == null)
            {
                return "Geçersiz Kart";
            }
            else
            {
                if (card.SpecialDiscount == false)
                {
                    if (card.Money < basePrice)
                    {
                        return "Geçersiz Bakiye";
                    }
                    else
                    {
                        card.Money -= basePrice;                        
                        return $"Geçebilirsiniz:) Kalan Bakiyeniz : {card.Money}";
                    }
                }
                else
                {
                    var privateCard = private_Card_List.FirstOrDefault(x => x.Id == ıd);
                    Console.WriteLine($"Tech City Gişelerine Hoş Geldiniz Sayın : {privateCard.Name} {privateCard.Surname}");
                    if (privateCard.Is_Student == true)
                    {
                        if (card.Money < (basePrice * 25 / 100))
                        {
                            return "Geçersiz Bakiye";
                        }
                        else
                        {
                            card.Money -= basePrice * 25 / 100;

                           return $"Geçebilirsiniz Kalan Bakiyeniz : {card.Money}";
                        }
                    }
                    else if (privateCard.Is_OlderThanSixty == true)
                    {
                        if (card.Money < (basePrice * 50 / 100))
                        {
                            return "Geçersiz Bakiye";
                        }
                        else
                        {
                            card.Money -= basePrice * 50 / 100;
                            return $"Geçebilirsiniz Kalan Bakiyeniz : {card.Money}";
                        }
                    }
                    else if (privateCard.Is_Worker == true)
                    {
                        if (card.Money < (basePrice * 75 / 100))
                        {
                            return "Geçersiz Bakiye";
                        }
                        else
                        {
                            card.Money -= basePrice * 75 / 100;
                            return $"Geçebilirsiniz Kalan Bakiyeniz : {card.Money}";
                        }
                    }
                    else
                    {
                        if (card.Money < basePrice)
                        {
                            return "Geçersiz Bakiye";
                        }
                        else
                        {
                            card.Money -= basePrice;
                            return $"Geçebilirsiniz Kalan Bakiyeniz : {card.Money}";
                        }
                    }
                }
                
            }
            Console.ReadLine();
        }

      
    }
}
