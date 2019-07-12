using Succes.Entities.Exceptions;
namespace Succes.Entities
{
    public class Player
    {
        /// <summary>
        /// Максимальная задолженность, которая может быть у игрока.
        /// Больше = проигрыш
        /// </summary>
        public readonly int MAX_DOUBT;
        /// <summary>
        /// Имя игрового персонажа
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Кол-во денег на счету
        /// </summary>
        public int Money { get; private set; }
        /// <summary>
        /// Добавляет указанное кол-во денег к счету игрока.
        /// Если долг становится слишком большим,
        /// возвращает <see cref="EnourmousDoubtException"/>
        /// </summary>
        /// <param name="addingAmount">Добавляемое кол-во денег</param>
        public void AddMoney(int addingAmount)
        {
            Money += addingAmount;
            if (Money < MAX_DOUBT)
                throw new EnourmousDoubtException();
        }
        public Player()
        {
            switch (Game.GetGame().Mode)
            {
                //TODO
                //Set up consts and so on
            }
        }
    }
}
