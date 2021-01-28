
using GameDemo.Entities;
using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager:BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Geçerli kullanıcı girmediniz!");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu başarıyla silindi : " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu başarıyla düzenlendi : " + player.FirstName);
        }
    }
}
