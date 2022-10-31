using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Ученики] " +
                    $"([Номер ученика], [ФИО], [Класс], [Классух], [Тариф], [День учебы])" +
                    $"VALUES ('{args[0]}', '{args[1]}', '{args[2]}', '{args[3]}', '{args[4]}', '{args[5]}')";
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

        public void Delete(string[] args)
        {
            // дома

            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}
