using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class classsCommand : ITableEditorCommand
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Классы] ([Код класса],[Класс],[Ученик]) VALUES ('{args[0]}','{args[1]}',{args[2]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            // дома

            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}";
             */
        }

        public void Delete(int number)
        {
            string query = $"DELETE FROM [Классы] WHERE [Код класса] = " + number;
            controller.ExecuteCommand(query);
        }
    }
}
